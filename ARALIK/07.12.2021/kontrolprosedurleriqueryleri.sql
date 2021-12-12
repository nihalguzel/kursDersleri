/* musteriekle(musteribilgileri)M�steri eklendi�inde insert yap�ld���nda musteri bilgileri tablosuna da veri ekleyecek trigger olusturuldu*/

/*MUSTER�LER TABLOSUN KAYIT EKLEND���NDE MUSTER� B�LG�LER�NE EKLEME YAPMAK*/
use bankadb/*Kullanacag�m�z veri taban�n� belirtmeliyiz*/
go
create Trigger musteribilgieklemetrg 
on musteriler
after insert
as
declare @musteriID int 
select @musteriID = ID from inserted
insert into musteribilgileri(musteriid,mbakiye) values(@musteriID,0)
insert into musteriler(madi,msoyadi,myas,hesapturid,durum) values('Merve','�zt�rk',27,1,'Aktif')
/*MUSTER�LER TABLOSUN KAYIT EKLEND���NDE MUSTER� B�LG�LER�NE EKLEME YAPMAK SONU*/

/*HAVALE �SLEMLER� TABLOSUNA EKLEME YAPILDI�INDA MUSTER�B�LG�LER� TABLOSUNDA BAK�YE G�NCELLEME*/
use bankadb
go
create Trigger Havalesonrasibakiyeguncelletrg
on havaleislemleri
after insert
as
declare @gondmusID int
declare @al�cmusID int
declare @tutar float
select @gondmusID=gondericihesapnoid , @al�cmusID=alicihesapnoid ,@tutar=havaletutar from inserted
update musteribilgileri set mbakiye=mbakiye-@tutar where musteriid=@gondmusID;
update musteribilgileri set mbakiye=mbakiye+@tutar where musteriid=@al�cmusID;

/*HAVALE �SLEMLER� TABLOSUNA EKLEME YAPILDI�INDA MUSTER�B�LG�LER� TABLOSUNDA BAK�YE G�NCELLEME*/

insert into havaleislemleri (alicihesapnoid,gondericihesapnoid,havaletutar,islemdurumu) values(3,2,200,'Aktif')


/*BAK�YEY� KONTROL ETME PROSED�R�*/
use bankadb
go
create proc paragonder
@alici int,
@gonderici int,
@tutar float

as
begin
declare @gondericibakiye float /*as den �nce yazd�g�m�z de��ikenler d��ar�dan parametre olarak istendi�i i�in bu de�i�keni begin i�inde tan�mlad�k*/
	begin try /*begin ile try ba�latt�k */
		begin tran havaleislemi /*tran transection anlam�nda kullan�l�r havale i�lemi ad�nda bir transection olu�turduk*/
			select @gondericibakiye=Sum(mbakiye) from musteribilgileri where musteriid=@gonderici/*gonderici m�sterinin bakiyesini ald�k ve gonderece�i tutardan b�y�km� diye kontrol edicez*/
			if @gondericibakiye>@tutar begin /* if blogunu olu�turduk burdaki begin s�sl� parantez gibi d���n�lerbilir*/ 
				insert into havaleislemleri(alicihesapnoid,gondericihesapnoid,havaletutar,islemdurumu) /*�art sagland�ysa havale islemlerine yeni kay�t eklenicek*/
				values(@alici,@gonderici,@tutar,'Ba�ar�l�')
				print 'Havale ��lemi Ba�ar�l�'
				end/*if blogunu bitirdik end ile s�sl� parantez gibi*/
			else begin /*else blogunu yine begin ile ba�latt�k s�sl� parantez gibi*/
				print 'Bakiye Yetersiz,L�tfen Tekrar Deneyin'
			end /*else blogunu end ile bitirdik s�sl� parantez gibi*/
		commit tran /*commit ile transection � bitirdiik*/
	end try /* try blogunu bitirdik*/
	begin catch/*yukar�dakiler d���nda bir hata var ise yakalamas� i�in catch blogunu olu�turduk ornegin tutar�n string girilmesi gibi*/
		rollback tran havaleislemi /*islemi transection ba��na g�nderiyoruz*/
		print'Beklenmedik bir hata olu�tu l�tfen tekrar deneyin'/*Hata Yazd�r�yoruz*/
	end catch/*catch blogunu bitirdik*/
end
/*BAK�YEY� KONTROL ETME PROSED�R� SONU */

exec paragonder 2,3,200

/*YETK� KONTROL ETME PROSED�R�*/
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
				print 'Para Yatirma �slemi Basarili'
			end
			else begin
				select @ad=personeller.padi,@soyad=personeller.psoyadi,@yetki1=yetkiler.yetkiadi from personeller  inner join yetkiler on (personeller.pyetki=yetkiler.ID) where personeller.ID=@personelid 
				print '��lemi Yapan Personel='+@ad+' '+@soyad+' '+'Personel Yetkisi='+@yetki1
				print 'Para Yat�rma ��lemi Ba�ar�s�z,Yetki Yok'
			end
		commit tran parayatir
	end try
	begin catch
		rollback tran parayatir
		print 'Beklenmedik Bir Hata Olu�tu'
	end catch

end
/*YETK� KONTROL ETME PROSED�R� SONU*/

exec parayatirma 2,3,500



