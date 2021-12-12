/* musteriekle(musteribilgileri)Müsteri eklendiðinde insert yapýldýðýnda musteri bilgileri tablosuna da veri ekleyecek trigger olusturuldu*/

/*MUSTERÝLER TABLOSUN KAYIT EKLENDÝÐÝNDE MUSTERÝ BÝLGÝLERÝNE EKLEME YAPMAK*/
use bankadb/*Kullanacagýmýz veri tabanýný belirtmeliyiz*/
go
create Trigger musteribilgieklemetrg 
on musteriler
after insert
as
declare @musteriID int 
select @musteriID = ID from inserted
insert into musteribilgileri(musteriid,mbakiye) values(@musteriID,0)
insert into musteriler(madi,msoyadi,myas,hesapturid,durum) values('Merve','Öztürk',27,1,'Aktif')
/*MUSTERÝLER TABLOSUN KAYIT EKLENDÝÐÝNDE MUSTERÝ BÝLGÝLERÝNE EKLEME YAPMAK SONU*/

/*HAVALE ÝSLEMLERÝ TABLOSUNA EKLEME YAPILDIÐINDA MUSTERÝBÝLGÝLERÝ TABLOSUNDA BAKÝYE GÜNCELLEME*/
use bankadb
go
create Trigger Havalesonrasibakiyeguncelletrg
on havaleislemleri
after insert
as
declare @gondmusID int
declare @alýcmusID int
declare @tutar float
select @gondmusID=gondericihesapnoid , @alýcmusID=alicihesapnoid ,@tutar=havaletutar from inserted
update musteribilgileri set mbakiye=mbakiye-@tutar where musteriid=@gondmusID;
update musteribilgileri set mbakiye=mbakiye+@tutar where musteriid=@alýcmusID;

/*HAVALE ÝSLEMLERÝ TABLOSUNA EKLEME YAPILDIÐINDA MUSTERÝBÝLGÝLERÝ TABLOSUNDA BAKÝYE GÜNCELLEME*/

insert into havaleislemleri (alicihesapnoid,gondericihesapnoid,havaletutar,islemdurumu) values(3,2,200,'Aktif')


/*BAKÝYEYÝ KONTROL ETME PROSEDÜRÜ*/
use bankadb
go
create proc paragonder
@alici int,
@gonderici int,
@tutar float

as
begin
declare @gondericibakiye float /*as den önce yazdýgýmýz deðþikenler dýþarýdan parametre olarak istendiði için bu deðiþkeni begin içinde tanýmladýk*/
	begin try /*begin ile try baþlattýk */
		begin tran havaleislemi /*tran transection anlamýnda kullanýlýr havale iþlemi adýnda bir transection oluþturduk*/
			select @gondericibakiye=Sum(mbakiye) from musteribilgileri where musteriid=@gonderici/*gonderici müsterinin bakiyesini aldýk ve gondereceði tutardan büyükmü diye kontrol edicez*/
			if @gondericibakiye>@tutar begin /* if blogunu oluþturduk burdaki begin süslü parantez gibi düþünülerbilir*/ 
				insert into havaleislemleri(alicihesapnoid,gondericihesapnoid,havaletutar,islemdurumu) /*þart saglandýysa havale islemlerine yeni kayýt eklenicek*/
				values(@alici,@gonderici,@tutar,'Baþarýlý')
				print 'Havale Ýþlemi Baþarýlý'
				end/*if blogunu bitirdik end ile süslü parantez gibi*/
			else begin /*else blogunu yine begin ile baþlattýk süslü parantez gibi*/
				print 'Bakiye Yetersiz,Lütfen Tekrar Deneyin'
			end /*else blogunu end ile bitirdik süslü parantez gibi*/
		commit tran /*commit ile transection ý bitirdiik*/
	end try /* try blogunu bitirdik*/
	begin catch/*yukarýdakiler dýþýnda bir hata var ise yakalamasý için catch blogunu oluþturduk ornegin tutarýn string girilmesi gibi*/
		rollback tran havaleislemi /*islemi transection baþýna gönderiyoruz*/
		print'Beklenmedik bir hata oluþtu lütfen tekrar deneyin'/*Hata Yazdýrýyoruz*/
	end catch/*catch blogunu bitirdik*/
end
/*BAKÝYEYÝ KONTROL ETME PROSEDÜRÜ SONU */

exec paragonder 2,3,200

/*YETKÝ KONTROL ETME PROSEDÜRÜ*/
use bankadb
go
create proc parayatirma
@personelid int,
@musteriid int,
@tutar float
as
begin
declare @yetki int
declare @ad nvarchar(20)
declare @soyad nvarchar(20)
declare @yetki1 nvarchar(20)
	begin try
		begin tran parayatir
			select @yetki=pyetki from personeller where ID=@personelid
			if @yetki=1 begin
				update musteribilgileri set mbakiye=mbakiye+@tutar where musteriid=@musteriid
				print 'Para Yatirma Ýslemi Basarili'
			end
			else begin
				select @ad=personeller.padi,@soyad=personeller.psoyadi,@yetki1=yetkiler.yetkiadi from personeller  inner join yetkiler on (personeller.pyetki=yetkiler.ID) where personeller.ID=@personelid 
				print 'Ýþlemi Yapan Personel='+@ad+' '+@soyad+' '+'Personel Yetkisi='+@yetki1
				print 'Para Yatýrma Ýþlemi Baþarýsýz,Yetki Yok'
			end
		commit tran parayatir
	end try
	begin catch
		rollback tran parayatir
		print 'Beklenmedik Bir Hata Oluþtu'
	end catch

end
/*YETKÝ KONTROL ETME PROSEDÜRÜ SONU*/

exec parayatirma 2,3,500



