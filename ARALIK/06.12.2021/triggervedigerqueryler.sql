select kategoriler.ID,urunler.urunadi from kategoriler inner join urunler on(kategoriler.ID=urunler.kategoriid)/*kategoriler tablosundaki �d ile urunlerdeki kategoriid de�erleri e�it olan verileri getirdik*/

select kategoriler.ID,urunler.urunadi from kategoriler left join urunler on(kategoriler.ID=urunler.kategoriid)/*soldaki tabloyu esas al�r ve e�le�enleri getirir e�le�meyenleri de bo� olarak yazar inner join de yaln�zca e�le�enleri getirir*/

select kategoriler.ID,urunler.urunadi from kategoriler right join urunler on(kategoriler.ID=urunler.kategoriid)/*sa�daki tabloyu esas al�r ve e�le�enleri getirir e�le�meyenleri de bo� olarak yazar inner join de yaln�zca e�le�enleri getirir*/

select kategoriler.ID,kategoriler.kategoriadi,urunler.urunadi from kategoriler full join urunler on(kategoriler.ID=urunler.kategoriid)/*iki tabloyu da esas al�r ve e�le�enleri getirir e�le�meyenleri de bo� olarak yazar inner join de yaln�zca e�le�enleri getirir*/

select stoktablo.ID,urunler.ID,urunler.urunadi,stoktablo.adet , urunler.fiyat,urunler.fiyat*stoktablo.adet as ToplamTutar from stoktablo left join urunler on(stoktablo.ID=urunler.ID)

select urunler.urunadi,stoktablo.adet from stoktablo left join urunler on(stoktablo.ID=urunler.ID) where stoktablo.adet>=10

select * from urunler where kategoriid is not null/* Kategorisi bo� olmayan de�erleri getirir null ya da null olmayan de�erleri bu �ekilde bulabiliriz*/

select * , 
case
when kategoriid=8
then 'Mobil Cihazlarda Kampanya Var'
else'Kampanyas�z �r�n'
end as Kampanya
from urunler /* kategoriid si 8 olan �r�nlerde kampanya oldu�unu belirten bir s�tun yazd�rd�k*/

select * , 
case
when kategoriid=8
then 'Mobil Cihazlarda Kampanya Var'
else'Kampanyas�z �r�n'
end as Kampanya,
case
when Durum='Stokta Var'
then 'Urun Stokta Mevcut'
else 'Urun Stokta Yok'
end as 'Stok Durumu'
from urunler/* kategoriid si 8 olan �r�nlerde kampanya oldu�unu belirten bir s�tun yazd�rd�k ve stok durumunuda ald�k*/

/*Trigger Kullan�m�*/
use vatanbilgisayar/*Kullanacag�m�z veri taban�n� belirtmeliyiz*/
go
create Trigger stokolusturma /*tetiklenecek komutun ad� belirtilir*/
on Urunler/*tetiklemenin nereden al�nacag� yaz�l�r burada belirtti�imiz urunler tablosuna bir insert oldu�unda tetikleme yap�lacak*/
after insert
as
declare @urunID int /*int tipinde urunID adl� bir de�i�ken tan�mlad�k*/
select @urunID = ID from inserted/*tan�mlad�g�m�z urunID de�i�kenine eklenen sat�r�n ID sini verdik*/
insert into stoktablo(urunid,adet,durum) values(@urunID,0,'Stokta Yok')/*stoktablosuna urunID ile birlikte ekleme yapt�k*/
/*Trigger Kullan�m� Sonu*/

insert into urunler (urunadi,durum,fiyat) values ('Mouse','Stokta Yok',50)/*Trigger i denemek i�in urun ekledik*/


/*Trigger Kullan�m�*/
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
/*Trigger Kullan�m� Sonu*/
insert into alistablo(urunid,adet) values (8,40)/*Trigger i denemek i�in alis kayd� ekledik*/

/*Trigger Kullan�m�*/
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
/*Trigger Kullan�m� Sonu*/
insert into satistablo(urunid,adet) values (8,10)/*Trigger i denemek i�in SAT�S kayd� ekledik*/

/*Trigger Kullan�m�*/
use vatanbilgisayar
go
create trigger urunsilstoksil
on urunler
after delete
as
declare @urunID int
select @urunID=ID from deleted
delete from stoktablo where @urunID=urunid
/*Trigger Kullan�m� Sonu*/
delete from urunler where ID=5/*Trigger i denemek i�in urunlerde 5 ID li kayd� sildik*/

/*Prosed�r Olu�turma*/
use vatanbilgisayar
go
create proc uruncagir
as
begin
select * from urunler
end
/*Prosed�r Olu�turma Sonu*/

/*Prosed�r Olu�turma*/
use vatanbilgisayar
go
create proc stokgetir
as
begin
select urunler.ID,urunler.urunadi,stoktablo.adet,stoktablo.durum from stoktablo inner join urunler on(stoktablo.urunid=urunler.ID)
end
/*Prosed�r Olu�turma Sonu*/

exec stokgetir

/*Prosed�r Olu�turma*/
use vatanbilgisayar
go
create proc urunfiyatgetir /*prosed�r�n ad�*/
@fiyat float/*prosed�r�n alaca�� parametre bunu prosed�r� �a��r�rken d��ar�dan g�ndericez*/
as
begin
select * from urunler where fiyat<=@fiyat /*d��ar�dan gelen fiyattan k���k ve e�it olanlar� getirecek*/
end
/*Prosed�r Olu�turma Sonu*/
exec urunfiyatgetir 5000

/*Prosed�r Olu�turma*/
use vatanbilgisayar
go
create proc urunfiyatgetirstoklu /*prosed�r�n ad�*/
@fiyat float,/*prosed�r�n alaca�� parametre bunu prosed�r� �a��r�rken d��ar�dan g�ndericez*/
@stok int
as
begin
select * from urunler inner join stoktablo on(urunler.ID=stoktablo.urunid) /*inner join ile stoktablosunu da birle�tirdik urunler.ID de�eri ile stoktablodaki urunid e�le�en de�erleri getirdik. */
where urunler.fiyat<=@fiyat and stoktablo.adet>=@stok /*d��ar�dan gelen fiyattan k���k ve d��ar�dan gelen adetten fazla olanlar� getirecek*/
end
/*Prosed�r Olu�turma Sonu*/
exec urunfiyatgetirstoklu 5000,30

/*Prosed�r ve Trigger Birlikte Kullan�m� Olu�turma*/
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

/*daha �nce olu�turmu� oldu�umuz stokekle triggeri urunler tablosuna insert yapt�g�m�z i�in otomatik olarak �al��t� ve stok hareketi ekledi*/
/*Prosed�r ve Trigger Birlikte Kullan�m� Sonu*/

exec urunekletriggerli 'Web Cam',8,'Stokta Yok',30

/*Prosed�r ve Trigger Birlikte Kullan�m� Olu�turma*/
use vatanbilgisayar
go
create proc urunsiltriggerli
@urunid int
as
begin
delete from urunler where(ID=@urunid)
end
/*Prosed�r ve Trigger Birlikte Kullan�m� Sonu*/
exec urunsiltriggerli 8