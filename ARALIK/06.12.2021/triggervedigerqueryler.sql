select kategoriler.ID,urunler.urunadi from kategoriler inner join urunler on(kategoriler.ID=urunler.kategoriid)/*kategoriler tablosundaki ýd ile urunlerdeki kategoriid deðerleri eþit olan verileri getirdik*/

select kategoriler.ID,urunler.urunadi from kategoriler left join urunler on(kategoriler.ID=urunler.kategoriid)/*soldaki tabloyu esas alýr ve eþleþenleri getirir eþleþmeyenleri de boþ olarak yazar inner join de yalnýzca eþleþenleri getirir*/

select kategoriler.ID,urunler.urunadi from kategoriler right join urunler on(kategoriler.ID=urunler.kategoriid)/*saðdaki tabloyu esas alýr ve eþleþenleri getirir eþleþmeyenleri de boþ olarak yazar inner join de yalnýzca eþleþenleri getirir*/

select kategoriler.ID,kategoriler.kategoriadi,urunler.urunadi from kategoriler full join urunler on(kategoriler.ID=urunler.kategoriid)/*iki tabloyu da esas alýr ve eþleþenleri getirir eþleþmeyenleri de boþ olarak yazar inner join de yalnýzca eþleþenleri getirir*/

select stoktablo.ID,urunler.ID,urunler.urunadi,stoktablo.adet , urunler.fiyat,urunler.fiyat*stoktablo.adet as ToplamTutar from stoktablo left join urunler on(stoktablo.ID=urunler.ID)

select urunler.urunadi,stoktablo.adet from stoktablo left join urunler on(stoktablo.ID=urunler.ID) where stoktablo.adet>=10

select * from urunler where kategoriid is not null/* Kategorisi boþ olmayan deðerleri getirir null ya da null olmayan deðerleri bu þekilde bulabiliriz*/

select * , 
case
when kategoriid=8
then 'Mobil Cihazlarda Kampanya Var'
else'Kampanyasýz Ürün'
end as Kampanya
from urunler /* kategoriid si 8 olan ürünlerde kampanya olduðunu belirten bir sütun yazdýrdýk*/

select * , 
case
when kategoriid=8
then 'Mobil Cihazlarda Kampanya Var'
else'Kampanyasýz Ürün'
end as Kampanya,
case
when Durum='Stokta Var'
then 'Urun Stokta Mevcut'
else 'Urun Stokta Yok'
end as 'Stok Durumu'
from urunler/* kategoriid si 8 olan ürünlerde kampanya olduðunu belirten bir sütun yazdýrdýk ve stok durumunuda aldýk*/

/*Trigger Kullanýmý*/
use vatanbilgisayar/*Kullanacagýmýz veri tabanýný belirtmeliyiz*/
go
create Trigger stokolusturma /*tetiklenecek komutun adý belirtilir*/
on Urunler/*tetiklemenin nereden alýnacagý yazýlýr burada belirttiðimiz urunler tablosuna bir insert olduðunda tetikleme yapýlacak*/
after insert
as
declare @urunID int /*int tipinde urunID adlý bir deðiþken tanýmladýk*/
select @urunID = ID from inserted/*tanýmladýgýmýz urunID deðiþkenine eklenen satýrýn ID sini verdik*/
insert into stoktablo(urunid,adet,durum) values(@urunID,0,'Stokta Yok')/*stoktablosuna urunID ile birlikte ekleme yaptýk*/
/*Trigger Kullanýmý Sonu*/

insert into urunler (urunadi,durum,fiyat) values ('Mouse','Stokta Yok',50)/*Trigger i denemek için urun ekledik*/


/*Trigger Kullanýmý*/
use vatanbilgisayar
go
create Trigger alis
on alistablo
after insert
as
declare @urunID int
declare @urunAdet int
select @urunID=urunid,@urunAdet=adet from inserted
update stoktablo set adet=adet+@urunAdet where urunid=@urunID
/*Trigger Kullanýmý Sonu*/
insert into alistablo(urunid,adet) values (8,40)/*Trigger i denemek için alis kaydý ekledik*/

/*Trigger Kullanýmý*/
use vatanbilgisayar
go
create Trigger satis
on satistablo
after insert
as
declare @urunID int
declare @satisAdet int
select @urunID=urunid,@satisAdet=adet from inserted
update stoktablo set adet=adet-@satisAdet where urunid=@urunID
/*Trigger Kullanýmý Sonu*/
insert into satistablo(urunid,adet) values (8,10)/*Trigger i denemek için SATÝS kaydý ekledik*/

/*Trigger Kullanýmý*/
use vatanbilgisayar
go
create trigger urunsilstoksil
on urunler
after delete
as
declare @urunID int
select @urunID=ID from deleted
delete from stoktablo where @urunID=urunid
/*Trigger Kullanýmý Sonu*/
delete from urunler where ID=5/*Trigger i denemek için urunlerde 5 ID li kaydý sildik*/

/*Prosedür Oluþturma*/
use vatanbilgisayar
go
create proc uruncagir
as
begin
select * from urunler
end
/*Prosedür Oluþturma Sonu*/

/*Prosedür Oluþturma*/
use vatanbilgisayar
go
create proc stokgetir
as
begin
select urunler.ID,urunler.urunadi,stoktablo.adet,stoktablo.durum from stoktablo inner join urunler on(stoktablo.urunid=urunler.ID)
end
/*Prosedür Oluþturma Sonu*/

exec stokgetir

/*Prosedür Oluþturma*/
use vatanbilgisayar
go
create proc urunfiyatgetir /*prosedürün adý*/
@fiyat float/*prosedürün alacaðý parametre bunu prosedürü çaðýrýrken dýþarýdan göndericez*/
as
begin
select * from urunler where fiyat<=@fiyat /*dýþarýdan gelen fiyattan küçük ve eþit olanlarý getirecek*/
end
/*Prosedür Oluþturma Sonu*/
exec urunfiyatgetir 5000

/*Prosedür Oluþturma*/
use vatanbilgisayar
go
create proc urunfiyatgetirstoklu /*prosedürün adý*/
@fiyat float,/*prosedürün alacaðý parametre bunu prosedürü çaðýrýrken dýþarýdan göndericez*/
@stok int
as
begin
select * from urunler inner join stoktablo on(urunler.ID=stoktablo.urunid) /*inner join ile stoktablosunu da birleþtirdik urunler.ID deðeri ile stoktablodaki urunid eþleþen deðerleri getirdik. */
where urunler.fiyat<=@fiyat and stoktablo.adet>=@stok /*dýþarýdan gelen fiyattan küçük ve dýþarýdan gelen adetten fazla olanlarý getirecek*/
end
/*Prosedür Oluþturma Sonu*/
exec urunfiyatgetirstoklu 5000,30

/*Prosedür ve Trigger Birlikte Kullanýmý Oluþturma*/
use vatanbilgisayar
go
create proc urunekletriggerli
@urunadi nvarchar(50),
@kategoriid int,
@durum nvarchar(10),
@fiyat float
as
begin
insert into urunler (urunadi,durum,kategoriid,fiyat) values(@urunadi,@durum,@kategoriid,@fiyat)
end

/*daha önce oluþturmuþ olduðumuz stokekle triggeri urunler tablosuna insert yaptýgýmýz için otomatik olarak çalýþtý ve stok hareketi ekledi*/
/*Prosedür ve Trigger Birlikte Kullanýmý Sonu*/

exec urunekletriggerli 'Web Cam',8,'Stokta Yok',30

/*Prosedür ve Trigger Birlikte Kullanýmý Oluþturma*/
use vatanbilgisayar
go
create proc urunsiltriggerli
@urunid int
as
begin
delete from urunler where(ID=@urunid)
end
/*Prosedür ve Trigger Birlikte Kullanýmý Sonu*/
exec urunsiltriggerli 8