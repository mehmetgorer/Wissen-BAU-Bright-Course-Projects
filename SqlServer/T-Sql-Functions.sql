--USER DEFINED FUNCTIONS (Kullanýcý Tanýmlý Fonksiyonlar)

--Aggregate fonksiyonlarý (Sum, Count, Avg, Max, Min gibi), DateAndTime fonksiyonlarý (DateDiff, DateAdd, DatePart gibi), String fonksiyonlarý (LEN, LEFT, RIGHT, Lower, Upper gibi), Diðer sistem fonksiyonlarý (@@Rowcount, @@error, @@Identity gibi) yanýsýra bizler de kullanýcý tanýmlý fonksiyonlar oluþturabiliriz.
use MovieMarket
go

select * from Filmler
select @@rowcount as filmsayýsý --en son aktif tablonun kayýt sayýsýný verir.

select DatePart(dd, getdate())
select DateAdd(mm, 2, getdate())

--create function Fonksiyonismi
--(Parametreler)
--returns GeriyeDönüþVeriTürü
--as
--begin
--T-Sql kodlarý...
--return geridönüþdeðeri
--end

--Fonksiyonlar T-Sorgularýn içinde kullanýlabilirler.

--Scalar-valued Functions (geriye deðer döndüren fonksiyonlar)

create function NullKontrol
(@KolonAdi varchar(20))
returns varchar(30)
as
begin
if(@KolonAdi is null)
	set @KolonAdi = 'Bilgi girilmemiþ'
return @KolonAdi
end

--Kullanýrken fonksiyonlarýn baþýna dbo (database owner) getiriyoruz.
select Adi, Soyadi, Telefon, dbo.NullKontrol(Adres) as Adres from Musteriler

select TurAdi, dbo.NullKontrol(Aciklama) as Açýklama from FilmTurleri

--Filmlerin satýþýnýn devam edip etmediðini (Varmi=1) kontrol eden fonksiyonu yazýnýz.
create function StokKontrol
(@KolonAdi varchar(20))
returns varchar(30)
as
begin
if(@KolonAdi = 1)
	set @KolonAdi = 'Stokta mevcut.'
else
	set @KolonAdi = 'Stokta yok.'
return @KolonAdi
end

select FilmAdi, Yonetmen, Oyuncular, dbo.StokKontrol(Varmi) as StokDurumu from Filmler

select FilmAdi, Yonetmen, Oyuncular, dbo.NullKontrol(Ozet) as FilmÖzeti, dbo.StokKontrol(Varmi) as StokDurumu from Filmler

update Filmler set Ozet=dbo.NullKontrol(Ozet)

--Müþteri numarasý (Id) girildiðinde müþterinin adýný ve soyadýný döndüren fonksiyonu yazýnýz.
alter function MusteriGetir(@MusteriId int)
returns varchar(30)
as
begin
 return (select Adi + ' ' + Soyadi from Musteriler where Id=@MusteriId) 
end

select dbo.MusteriGetir(MusteriId) as Müþteri, Adet, BirimFiyat, Adet*BirimFiyat as Tutar from FilmSatis

select dbo.MusteriGetir(2) as Müþteri

--Table-valued Functions (geriye tablo döndüren fonksiyonlar)

--Genel olarak view nesnelerine benzerler.

--Müþteri Id girildiðinde ilgili müþterinin satýþ bilgilerini tablo olarak döndüren fonksiyonu yazýnýz.

create function SatislarByMusteri
(@MusteriId int)
returns table
as
return (select *, Adet*BirimFiyat as Tutar from FilmSatis where MusteriId=@MusteriId)

select * from dbo.SatislarByMusteri(2)

create function DetayliSatisRaporu(@kdvOrani tinyint)
returns @DetayliSatisTablosu table(
	SatisId int primary key not null,
	Tarih datetime,
	FilmId int,
	MusteriId int,
	Adet int,
	BirimFiyat money,
	Tutar money,
	KdvOrani tinyint,
	KdvTutari money,
	ToplamTutar money
)
as
begin
	insert into @DetayliSatisTablosu(SatisId, Tarih, FilmId, MusteriId, Adet, BirimFiyat, Tutar, KdvOrani, KdvTutari, ToplamTutar)
	select Id, Tarih, FilmId, MusteriId, Adet, BirimFiyat, Adet*BirimFiyat, @kdvOrani, Adet*BirimFiyat*@kdvOrani/100, Adet*BirimFiyat + (Adet*BirimFiyat*@kdvOrani/100) from FilmSatis
	return
end

select * from dbo.DetayliSatisRaporu(20)

select dbo.MusteriGetir(MusteriId) as Müþteri, Adet, BirimFiyat, Tutar, KdvOrani, KdvTutari, ToplamTutar from dbo.DetayliSatisRaporu(20)
