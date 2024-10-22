--Kullan�c� Tan�ml� Veri T�rleri (User Defined Data Types)
--Sql'de mevcut olan veri t�rlerinden yararlanarak kullan�c�lar taraf�ndan olu�turulan veri t�rleridir.
--Aktif veritaban�na kay�t edilir, e�er yeni olu�turulacak veritabanlar�nda da kullan�lmak istenilirse Model system database'ine kay�t edilmelidir.

--Kullan�c� tan�ml� veri t�r� olu�turmak i�in sp_addtype, iptal etmek i�in sp_droptype sistem stored procedure'leri kullan�l�r.

--Kullan�c� tan�ml� veri t�rleri Programmability-Types-User-DEfined Data Types alt�nda listelenmektedir.

use OrnekDb
go
sp_addtype Adres, 'varchar(200)', null

sp_addtype Maas, 'money'

sp_droptype Maas  --silinebilmesi i�in hi�bir tabloda kay�tl� olmamas� gerekir.

--Local De�i�kenler (Haf�za De�i�kenleri)

--Declare @De�i�kenAd� verit�r�
Declare @Adi varchar(50)
set @Adi = 'Mert'
--select @Adi as �sim
print @Adi

--Declare sat�rlar� mutlaka her �al��t�rmada se�ili olmal�d�r.

declare @sayi1 int 
declare @sayi2 int = 6
set @sayi1=2
select @sayi1 + @sayi2 as Sonu�
declare @toplam int
set @toplam = @sayi1 + @sayi2
select @toplam as Sonu�

declare @s3 int, @s4 int
set @s3 = 4
set @s4 = 12
if(@s3 > @s4)
begin
	select @s3/@s4 as Sonu�
end
else
begin
	select @s4/@s3 as Sonu�
end

use MovieMarket
go
declare @EnYuksekAlisveris money
set @EnYuksekAlisveris = (select Max(Adet*BirimFiyat) from FilmSatis)
select @EnYuksekAlisveris as MaxTutar

declare @MaxAdet int, @AvgFiyat money
select @MaxAdet = Max(Adet), @AvgFiyat = Avg(BirimFiyat) from FilmSatis
select @MaxAdet as 'En Y�ksek Adet', @AvgFiyat as 'Ortalama Fiyat'