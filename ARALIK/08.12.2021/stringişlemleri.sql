/*String ��lemleri*/

/*Char �ndex*/

select CHARINDEX('Kaya','Erhan Kaya')/*Kaya de�erine kadar olan characterleri sayar ve K harfinin ba�lad��� yeri veri*/

/*Concat*/

select CONCAT('Elif',' Y�ld�z') as AdSoyad/*Verilen de�erleri birle�tirir*/


/*Concat_ws*/

select CONCAT_WS(',','�eyma','Akar','Akmaz') as AdSoyad /*Verilen iki de�eri aras�na ilk girdi�imiz karakteri koyarak birle�tirir*/

/*Left*/

select LEFT('Burak �zt�rk',3), LEFT('Kaan',1) as isimler /*Soldan parantez i�inde belirtti�imiz kadar de�eri al�r*/

/*Right*/

select RIGHT('Ay�en',3) as Aysen /*Sa�dan parantez i�inde belirtti�imiz kadar de�eri al�r*/

/*LEN*/ 

select LEN ('Bilgen Bi�er') /*Bo�lukla Beraber t�m karakter say�s�n� verir*/

/*LOWER*/

select LOWER('mUHaMMeT') /*t�m karakterleri k���k harfe �evirir*/


/*UPPER*/

select UPPER ('niHal') /*t�m karakterleri b�y�k harfe �evirir*/

/*LTRIM*/

select LTRIM ('                Ahmet �ENT�RK              ') /*Ba�tan ve sondan olan ba�l�klar� siler*/

/*PATINDEX*/

select PATINDEX('%a%','Mikail') /*%% aras�nda belirtilen karakter ney ise girilen de�erin i�indeki yerinin indexini verir*/
select PATINDEX('i%','�smail') /*%nin ba��ndaki de�er ile ba�layan de�erlerin say�s�n� verir*/
select PATINDEX('%t','�smet') /*verilen de�er ile biten yerin indexini verir */