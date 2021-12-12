use bankadb
go
create proc musteriekleme
/*Dýþarýdan parametre olarak alacaðýmýz deðerler*/
@personelid int,
@mad nvarchar(50),
@msoyad nvarchar(50),
@myas int,
@mdurum nvarchar(20)
as
begin
/*Ýçeride kullanacgýmýz local deðiþkenler*/
declare @hesapturID int
declare @personelyetkiID int
declare @hesapturadi nvarchar(20)
begin try
	begin tran musteriekle /*transection adi fonksiyon adý olarak düþünülebilir*/
		select @personelyetkiID=personeller.pyetki from personeller where ID=@personelid/*dýþarýdan gelen personelidye göre personeller tablosundan personelin yetkisini alýyoruz*/
		if @personelyetkiID=2 begin/*Personel yetki idsi 2 ise yetkiler tablosunda bireysel müþteri temsilcisi oldugundan açýlan hesap bireysel hesap olarak eklenecek*/
			insert into musteriler(madi,msoyadi,myas,hesapturid,durum) values(@mad,@msoyad,@myas,1,'Aktif')/*hesap turlerinde bireysel hesap ID si 1 olduðu için musteri eklerken hesapturuid sini 1 olarak gönderdik*/
			select @hesapturadi=hesapturuadi from hesapturleri where ID=1
			print @mad + ' ' + @msoyad + 'Kiþisine Ait' +@hesapturadi+ 'hesabý oluþturuldu'
		end
		else if @personelyetkiID=3 begin/*Personel yetki idsi 3 ise yetkiler tablosunda kurumsa müþteri temsilcisi oldugundan açýlan hesap kurumsal hesap olarak eklenecek*/
			insert into musteriler(madi,msoyadi,myas,hesapturid,durum) values(@mad,@msoyad,@myas,2,'Aktif')/*hesap turlerinde bireysel hesap ID si 2 olduðu için musteri eklerken hesapturuid sini 2 olarak gönderdik*/
			select @hesapturadi=hesapturuadi from hesapturleri where ID=2
			print @mad + ' ' + @msoyad + 'Kiþisine Ait' +@hesapturadi+ 'hesabý oluþturuldu'
		end
		else if @personelyetkiID=4 begin
			insert into musteriler(madi,msoyadi,myas,hesapturid,durum) values(@mad,@msoyad,@myas,3,'Aktif')
			select @hesapturadi=hesapturuadi from hesapturleri where ID=3
			print @mad + ' ' + @msoyad + 'Kiþisine Ait' +@hesapturadi+ 'hesabý oluþturuldu'
		end
		else begin
			Print 'Ekleme Yapacak Personelin Yetkisi Bulunmamaktadýr.' 
		end
	commit tran musteriekle
end try
begin catch
rollback tran musteriekle
print 'Beklenmedik Bir Hata Oluþtu'
end catch
end

exec musteriekleme 1,'Ad 1','Soyad 1',35,'Aktif'