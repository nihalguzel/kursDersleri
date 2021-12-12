select * from urunler

select * from stoktablo

select sum (adet) as ToplamAdet from stoktablo /*verilen sütun adýnýn toplamýný verir as de responsedaki kolon adýný oluþturur*/

select count(ID) as ToplamKategori from kategoriler /*Verilen tablodaki sutun altýnda bulunan satýr sayýsýný verir*/

select avg(fiyat) as OrtalamaFiyat from urunler/*Urunler tablosundaki fiyat sütunun ortlamasýný verir*/

select min(fiyat) as MinimumFiyat from urunler/*urunler tablosunda fiyat sütunundaki minimum deðeri verir*/

select urunadi,fiyat from urunler where fiyat=(select min(fiyat) from urunler)/*Urunler tablosunda fiyatý minimum olan satýrýn urunadi ve fiyatini verir*/

select max(fiyat) as MinimumFiyat from urunler/*urunler tablosunda fiyat sütunundaki max deðeri verir*/

select * from urunler where fiyat > 8500 /* urunler tablosunda fiyatý sütunundaki deðer 8.500 den büyük olan deðerleri verir*/

select * from stoktablo where adet > 10 /*stoktablo tablosunda adeti 10 dan büyük olan deðerleri getirir*/

update urunler set fiyat =fiyat*1.1 where fiyat<=8500 /*urunler tablosunda fiyatý 8.500 den küçük olan ürünlerin fiyatýnýn 1.1 oranýnda artýrýp güncelleyecek*/

select urunadi,fiyat,fiyat*1.18 as KdvDahil from urunler/*urunler tablosundan fiyatlarý getirdi 1.18 le çarparak kdvdahil fiyatýný verdi ancak tabloya birþey eklemedi iþlem yaparak sonuc verdi*/

select urunadi,fiyat,fiyat*1.18 as 'KdvDahil',fiyat*0.8 as'ÝndirimliFiyat' ,(fiyat*0.8)*1.8 as 'Ýndirimli Kdvli Fiyat' from urunler/*Fiyatý aldýktan sonra kdvdahil fiyat ana fiyat üzerinden indirimli fiyat ve indirimli fiyat üzerinden kdv dahil fiyatý getirdik*/

select * from urunler order by fiyat desc /*Fiyat Sütununa göre büyükten küçüðe sýralar string degerler için ise A-Z ye sýralar*/

select * from urunler order by fiyat asc /*Fiyat Sütununa göre kucukten buyuge sýralar string degerler için ise Z-A ya sýralar*/

select ROUND(fiyat,1)from urunler/*En yakýn yere yuvarlar*/

select FLOOR(fiyat)from urunler/*Aþaðý yuvarlar tamsayý*/

select CEILING(fiyat,1)from urunler/*Yukarý yuvarlar*/

update urunler set kategoriid=REPLACE(kategoriid,5,7) where ID=7 /*urunlertablosundaki kategoriid hücresindeki 5 deðerini 7 yapar ID si 7 olan satýrda*/

update urunler set kategoriid=REPLACE(kategoriid,3,8)/*urunler tablosundaki kategorid sütununda 3 olan deðerleri 8 yapar*/

select kategoriid,COUNT(*) as'Kategorideki Ürün Sayýsý' from urunler group by kategoriid  /*kategoriid sütunu tamamen çek dedik ve urunler tablosunda kategoriidye göre gruplayarak sonuc donduruyor*/

select * from urunler inner join stoktablo on(urunler.ID=stoktablo.urunid)/*urunler ve stokkablosu tablolarýný urunlerdeki ýd ile stoktaki urun ýd eþleþtirerek yazdý*/

select urunler.urunadi,stoktablo.adet from urunler inner join stoktablo on (urunler.ID=stoktablo.urunid)/*iki tablodan urunid leri eþleþen kayýtlardan urunlerden urunadini stoktablodan adetlerini getirdik*/

select urunler.urunadi,stoktablo.adet,stoktablo.adet*urunler.fiyat as ToplamTutar from urunler inner join stoktablo on (urunler.ID=stoktablo.urunid)/*urunlerde id ler ile stoktablodaki urunýd eþleþen kayýtlarýn stoktablodaki adet ile urunler deki fiyatý çarparak ürün bazlý toplam fiaytý aldýk*/

select sum (stoktablo.adet*urunler.fiyat) as ToplamFiyat from Urunler inner join stoktablo on(Urunler.ID=stoktablo.urunid)/* Tüm ürünlerin toplam tutarlarýný toplayarak stoktaki toplam fiyatý bulduk*/
