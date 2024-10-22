--Kullanýcý Tanýmlý Veri Türleri (User Defined Data Types)
--Sql'de mevcut olan veri türlerinden yararlanarak kullanýcýlar tarafýndan oluþturulan veri türleridir.
--Aktif veritabanýna kayýt edilir, eðer yeni oluþturulacak veritabanlarýnda da kullanýlmak istenilirse Model system database'ine kayýt edilmelidir.

--Kullanýcý tanýmlý veri türü oluþturmak için sp_addtype, iptal etmek için sp_droptype sistem stored procedure'leri kullanýlýr.

--Kullanýcý tanýmlý veri türleri Programmability-Types-User-DEfined Data Types altýnda listelenmektedir.

use OrnekDb
go
sp_addtype Adres, 'varchar(200)', null

sp_addtype Maas, 'money'

sp_droptype Maas  --silinebilmesi için hiçbir tabloda kayýtlý olmamasý gerekir.

--Local Deðiþkenler (Hafýza Deðiþkenleri)

--Declare @DeðiþkenAdý veritürü
Declare @Adi varchar(50)
set @Adi = 'Mert'
--select @Adi as Ýsim
print @Adi

--Declare satýrlarý mutlaka her çalýþtýrmada seçili olmalýdýr.

declare @sayi1 int 
declare @sayi2 int = 6
set @sayi1=2
select @sayi1 + @sayi2 as Sonuç
declare @toplam int
set @toplam = @sayi1 + @sayi2
select @toplam as Sonuç

declare @s3 int, @s4 int
set @s3 = 4
set @s4 = 12
if(@s3 > @s4)
begin
	select @s3/@s4 as Sonuç
end
else
begin
	select @s4/@s3 as Sonuç
end

use MovieMarket
go
declare @EnYuksekAlisveris money
set @EnYuksekAlisveris = (select Max(Adet*BirimFiyat) from FilmSatis)
select @EnYuksekAlisveris as MaxTutar

declare @MaxAdet int, @AvgFiyat money
select @MaxAdet = Max(Adet), @AvgFiyat = Avg(BirimFiyat) from FilmSatis
select @MaxAdet as 'En Yüksek Adet', @AvgFiyat as 'Ortalama Fiyat'