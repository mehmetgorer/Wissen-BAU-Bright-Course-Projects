--USER DEFINED FUNCTIONS (Kullan�c� Tan�ml� Fonksiyonlar)

--Aggregate fonksiyonlar� (Sum, Count, Avg, Max, Min gibi), DateAndTime fonksiyonlar� (DateDiff, DateAdd, DatePart gibi), String fonksiyonlar� (LEN, LEFT, RIGHT, Lower, Upper gibi), Di�er sistem fonksiyonlar� (@@Rowcount, @@error, @@Identity gibi) yan�s�ra bizler de kullan�c� tan�ml� fonksiyonlar olu�turabiliriz.
use MovieMarket
go

select * from Filmler
select @@rowcount as filmsay�s� --en son aktif tablonun kay�t say�s�n� verir.

select DatePart(dd, getdate())
select DateAdd(mm, 2, getdate())

--create function Fonksiyonismi
--(Parametreler)
--returns GeriyeD�n��VeriT�r�
--as
--begin
--T-Sql kodlar�...
--return gerid�n��de�eri
--end

--Fonksiyonlar T-Sorgular�n i�inde kullan�labilirler.

--Scalar-valued Functions (geriye de�er d�nd�ren fonksiyonlar)

create function NullKontrol
(@KolonAdi varchar(20))
returns varchar(30)
as
begin
if(@KolonAdi is null)
	set @KolonAdi = 'Bilgi girilmemi�'
return @KolonAdi
end

--Kullan�rken fonksiyonlar�n ba��na dbo (database owner) getiriyoruz.
select Adi, Soyadi, Telefon, dbo.NullKontrol(Adres) as Adres from Musteriler

select TurAdi, dbo.NullKontrol(Aciklama) as A��klama from FilmTurleri

--Filmlerin sat���n�n devam edip etmedi�ini (Varmi=1) kontrol eden fonksiyonu yaz�n�z.
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

select FilmAdi, Yonetmen, Oyuncular, dbo.NullKontrol(Ozet) as Film�zeti, dbo.StokKontrol(Varmi) as StokDurumu from Filmler

update Filmler set Ozet=dbo.NullKontrol(Ozet)

--M��teri numaras� (Id) girildi�inde m��terinin ad�n� ve soyad�n� d�nd�ren fonksiyonu yaz�n�z.
alter function MusteriGetir(@MusteriId int)
returns varchar(30)
as
begin
 return (select Adi + ' ' + Soyadi from Musteriler where Id=@MusteriId) 
end

select dbo.MusteriGetir(MusteriId) as M��teri, Adet, BirimFiyat, Adet*BirimFiyat as Tutar from FilmSatis

select dbo.MusteriGetir(2) as M��teri

--Table-valued Functions (geriye tablo d�nd�ren fonksiyonlar)

--Genel olarak view nesnelerine benzerler.

--M��teri Id girildi�inde ilgili m��terinin sat�� bilgilerini tablo olarak d�nd�ren fonksiyonu yaz�n�z.

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

select dbo.MusteriGetir(MusteriId) as M��teri, Adet, BirimFiyat, Tutar, KdvOrani, KdvTutari, ToplamTutar from dbo.DetayliSatisRaporu(20)
