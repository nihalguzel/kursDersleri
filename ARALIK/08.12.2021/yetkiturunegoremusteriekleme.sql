use bankadb
go
create proc musteriekleme
/*D��ar�dan parametre olarak alaca��m�z de�erler*/
@personelid int,
@mad nvarchar(50),
@msoyad nvarchar(50),
@myas int,
@mdurum nvarchar(20)
as
begin
/*��eride kullanacg�m�z local de�i�kenler*/
declare @hesapturID int
declare @personelyetkiID int
declare @hesapturadi nvarchar(20)
begin try
	begin tran musteriekle /*transection adi fonksiyon ad� olarak d���n�lebilir*/
		select @personelyetkiID=personeller.pyetki from personeller where ID=@personelid/*d��ar�dan gelen personelidye g�re personeller tablosundan personelin yetkisini al�yoruz*/
		if @personelyetkiID=2 begin/*Personel yetki idsi 2 ise yetkiler tablosunda bireysel m��teri temsilcisi oldugundan a��lan hesap bireysel hesap olarak eklenecek*/
			insert into musteriler(madi,msoyadi,myas,hesapturid,durum) values(@mad,@msoyad,@myas,1,'Aktif')/*hesap turlerinde bireysel hesap ID si 1 oldu�u i�in musteri eklerken hesapturuid sini 1 olarak g�nderdik*/
			select @hesapturadi=hesapturuadi from hesapturleri where ID=1
			print @mad + ' ' + @msoyad + 'Ki�isine Ait' +@hesapturadi+ 'hesab� olu�turuldu'
		end
		else if @personelyetkiID=3 begin/*Personel yetki idsi 3 ise yetkiler tablosunda kurumsa m��teri temsilcisi oldugundan a��lan hesap kurumsal hesap olarak eklenecek*/
			insert into musteriler(madi,msoyadi,myas,hesapturid,durum) values(@mad,@msoyad,@myas,2,'Aktif')/*hesap turlerinde bireysel hesap ID si 2 oldu�u i�in musteri eklerken hesapturuid sini 2 olarak g�nderdik*/
			select @hesapturadi=hesapturuadi from hesapturleri where ID=2
			print @mad + ' ' + @msoyad + 'Ki�isine Ait' +@hesapturadi+ 'hesab� olu�turuldu'
		end
		else if @personelyetkiID=4 begin
			insert into musteriler(madi,msoyadi,myas,hesapturid,durum) values(@mad,@msoyad,@myas,3,'Aktif')
			select @hesapturadi=hesapturuadi from hesapturleri where ID=3
			print @mad + ' ' + @msoyad + 'Ki�isine Ait' +@hesapturadi+ 'hesab� olu�turuldu'
		end
		else begin
			Print 'Ekleme Yapacak Personelin Yetkisi Bulunmamaktad�r.' 
		end
	commit tran musteriekle
end try
begin catch
rollback tran musteriekle
print 'Beklenmedik Bir Hata Olu�tu'
end catch
end

exec musteriekleme 1,'Ad 1','Soyad 1',35,'Aktif'