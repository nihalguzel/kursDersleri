/*String Ýþlemleri*/

/*Char Ýndex*/

select CHARINDEX('Kaya','Erhan Kaya')/*Kaya deðerine kadar olan characterleri sayar ve K harfinin baþladýðý yeri veri*/

/*Concat*/

select CONCAT('Elif',' Yýldýz') as AdSoyad/*Verilen deðerleri birleþtirir*/


/*Concat_ws*/

select CONCAT_WS(',','Þeyma','Akar','Akmaz') as AdSoyad /*Verilen iki deðeri arasýna ilk girdiðimiz karakteri koyarak birleþtirir*/

/*Left*/

select LEFT('Burak Öztürk',3), LEFT('Kaan',1) as isimler /*Soldan parantez içinde belirttiðimiz kadar deðeri alýr*/

/*Right*/

select RIGHT('Ayþen',3) as Aysen /*Saðdan parantez içinde belirttiðimiz kadar deðeri alýr*/

/*LEN*/ 

select LEN ('Bilgen Biçer') /*Boþlukla Beraber tüm karakter sayýsýný verir*/

/*LOWER*/

select LOWER('mUHaMMeT') /*tüm karakterleri küçük harfe çevirir*/


/*UPPER*/

select UPPER ('niHal') /*tüm karakterleri büyük harfe çevirir*/

/*LTRIM*/

select LTRIM ('                Ahmet ÞENTÜRK              ') /*Baþtan ve sondan olan baþlýklarý siler*/

/*PATINDEX*/

select PATINDEX('%a%','Mikail') /*%% arasýnda belirtilen karakter ney ise girilen deðerin içindeki yerinin indexini verir*/
select PATINDEX('i%','Ýsmail') /*%nin baþýndaki deðer ile baþlayan deðerlerin sayýsýný verir*/
select PATINDEX('%t','Ýsmet') /*verilen deðer ile biten yerin indexini verir */