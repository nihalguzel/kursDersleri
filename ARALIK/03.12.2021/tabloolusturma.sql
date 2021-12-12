Create Table urunler(
ID int primary key identity(1,1) not null,
urunadi nvarchar(50),
durum nvarchar(10),
kategoriid int,
fiyat float);

Create Table kategoriler(
ID int primary key identity(1,1) not null,
kategoriadi nvarchar(50),
durum nvarchar(10)
);

Create Table alistablo(
ID int primary key identity(1,1) not null,
urunid int,
adet int,
);

Create Table satistablo(
ID int primary key identity(1,1) not null,
urunid int,
adet int,
);

Create Table stoktablo(
ID int primary key identity(1,1) not null,
urunid int,
adet int,
durum nvarchar(10)
);