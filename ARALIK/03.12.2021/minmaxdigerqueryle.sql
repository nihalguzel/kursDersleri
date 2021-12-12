select * from urunler

select * from stoktablo

select sum (adet) as ToplamAdet from stoktablo /*verilen s�tun ad�n�n toplam�n� verir as de responsedaki kolon ad�n� olu�turur*/

select count(ID) as ToplamKategori from kategoriler /*Verilen tablodaki sutun alt�nda bulunan sat�r say�s�n� verir*/

select avg(fiyat) as OrtalamaFiyat from urunler/*Urunler tablosundaki fiyat s�tunun ortlamas�n� verir*/

select min(fiyat) as MinimumFiyat from urunler/*urunler tablosunda fiyat s�tunundaki minimum de�eri verir*/

select urunadi,fiyat from urunler where fiyat=(select min(fiyat) from urunler)/*Urunler tablosunda fiyat� minimum olan sat�r�n urunadi ve fiyatini verir*/

select max(fiyat) as MinimumFiyat from urunler/*urunler tablosunda fiyat s�tunundaki max de�eri verir*/

select * from urunler where fiyat > 8500 /* urunler tablosunda fiyat� s�tunundaki de�er 8.500 den b�y�k olan de�erleri verir*/

select * from stoktablo where adet > 10 /*stoktablo tablosunda adeti 10 dan b�y�k olan de�erleri getirir*/

update urunler set fiyat =fiyat*1.1 where fiyat<=8500 /*urunler tablosunda fiyat� 8.500 den k���k olan �r�nlerin fiyat�n�n 1.1 oran�nda art�r�p g�ncelleyecek*/

select urunadi,fiyat,fiyat*1.18 as KdvDahil from urunler/*urunler tablosundan fiyatlar� getirdi 1.18 le �arparak kdvdahil fiyat�n� verdi ancak tabloya bir�ey eklemedi i�lem yaparak sonuc verdi*/

select urunadi,fiyat,fiyat*1.18 as 'KdvDahil',fiyat*0.8 as'�ndirimliFiyat' ,(fiyat*0.8)*1.8 as '�ndirimli Kdvli Fiyat' from urunler/*Fiyat� ald�ktan sonra kdvdahil fiyat ana fiyat �zerinden indirimli fiyat ve indirimli fiyat �zerinden kdv dahil fiyat� getirdik*/

select * from urunler order by fiyat desc /*Fiyat S�tununa g�re b�y�kten k����e s�ralar string degerler i�in ise A-Z ye s�ralar*/

select * from urunler order by fiyat asc /*Fiyat S�tununa g�re kucukten buyuge s�ralar string degerler i�in ise Z-A ya s�ralar*/

select ROUND(fiyat,1)from urunler/*En yak�n yere yuvarlar*/

select FLOOR(fiyat)from urunler/*A�a�� yuvarlar tamsay�*/

select CEILING(fiyat,1)from urunler/*Yukar� yuvarlar*/

update urunler set kategoriid=REPLACE(kategoriid,5,7) where ID=7 /*urunlertablosundaki kategoriid h�cresindeki 5 de�erini 7 yapar ID si 7 olan sat�rda*/

update urunler set kategoriid=REPLACE(kategoriid,3,8)/*urunler tablosundaki kategorid s�tununda 3 olan de�erleri 8 yapar*/

select kategoriid,COUNT(*) as'Kategorideki �r�n Say�s�' from urunler group by kategoriid  /*kategoriid s�tunu tamamen �ek dedik ve urunler tablosunda kategoriidye g�re gruplayarak sonuc donduruyor*/

select * from urunler inner join stoktablo on(urunler.ID=stoktablo.urunid)/*urunler ve stokkablosu tablolar�n� urunlerdeki �d ile stoktaki urun �d e�le�tirerek yazd�*/

select urunler.urunadi,stoktablo.adet from urunler inner join stoktablo on (urunler.ID=stoktablo.urunid)/*iki tablodan urunid leri e�le�en kay�tlardan urunlerden urunadini stoktablodan adetlerini getirdik*/

select urunler.urunadi,stoktablo.adet,stoktablo.adet*urunler.fiyat as ToplamTutar from urunler inner join stoktablo on (urunler.ID=stoktablo.urunid)/*urunlerde id ler ile stoktablodaki urun�d e�le�en kay�tlar�n stoktablodaki adet ile urunler deki fiyat� �arparak �r�n bazl� toplam fiayt� ald�k*/

select sum (stoktablo.adet*urunler.fiyat) as ToplamFiyat from Urunler inner join stoktablo on(Urunler.ID=stoktablo.urunid)/* T�m �r�nlerin toplam tutarlar�n� toplayarak stoktaki toplam fiyat� bulduk*/
