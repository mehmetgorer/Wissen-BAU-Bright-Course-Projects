--STORED PROCEDURES (Saklý Yordamlar)

--T-Sql komutlarýyla program yazýlabilen sql nesneleridir.
--Uygulama yazýlýmlarý tarafýndan kullanýlabilirler.
--Network trafiðini azaltarak performans ve güvenliði artýrýrlar.
--Dýþarýdan parametre alabilirler (input), dýþarýya sonuç (output) döndürebilirler.

use MovieMarket
go

create procedure sp_FilmleriGetir
as
select FilmAdi, TurAdi, Yonetmen, Oyuncular from Filmler inner join FilmTurleri on Filmler.TurId = FilmTurleri.Id
go

Exec sp_FilmleriGetir

--SP kodlarý ilk çalýþtýrýldýðýnda bir çalýþma planý (Execute Plan) oluþturulur. Eðer sorgu sonucu deðiþkenlik gösteren dinamik bir yapýda deðilse, bu büyük bir performans avantajý saðlayacaktýr.

--Ancak sorgu sýklýkla deðiþen dinamik bir yapýdaysa SP içinde recompile kullanmamýz gerekli olacaktýr.

alter procedure sp_FilmleriGetir
with recompile, encryption
as
select FilmAdi, TurAdi, Yonetmen, Oyuncular from Filmler inner join FilmTurleri on Filmler.TurId = FilmTurleri.Id
go

sp_helptext 'sp_FilmleriGetir'

--encryption özelliði olmadan çalýþtýrdýðýmýzda kodlar tekrar görünür hale geliyor.
alter procedure sp_FilmleriGetir
with recompile
as
select FilmAdi, TurAdi, Yonetmen, Oyuncular from Filmler inner join FilmTurleri on Filmler.TurId = FilmTurleri.Id
go

Exec ('Select * from Filmler')

create proc sp_DinamikSorgu
@TabloAdi varchar(30)  --default olarak input parametre kabul edilir.
as
Exec ('Select * from ' + @TabloAdi)
go

Exec sp_DinamikSorgu 'Filmler'

Declare @Tablo varchar(30) = 'Musteriler'
Exec sp_DinamikSorgu @Tablo

create proc sp_Topla
@sayi1 int, @sayi2 int
as
select @sayi1 + @sayi2 as Toplam
go

exec sp_Topla 5,6

alter proc sp_Topla
@sayi1 int, @sayi2 int,
@sonuc int output
as
set @sonuc = @sayi1 + @sayi2 
go

declare @toplam int
exec sp_Topla 4,8,@toplam output
select @toplam as Toplam

declare @toplam int
exec sp_Topla 
@sayi1=4,
@sayi2=8,
@sonuc=@toplam output
select @toplam as Toplam

create proc sp_MusteriEkle
@Adi varchar(20),
@Soyadi varchar(20),
@Telefon varchar(20),
@Adres varchar(100)
as
insert into Musteriler(Adi, Soyadi, Telefon, Adres) values(@Adi, @Soyadi, @Telefon, @Adres)
go

exec sp_MusteriEkle 'Eyyup', 'Albayrak', '5446756544', 'Arnavutköy-Ýstanbul'

exec sp_MusteriEkle
@Adi='Hidayet',
@Soyadi='Güleç',
@Telefon='54253463635',
@Adres='Kaðýthane-Ýstanbul'
select @@IDENTITY as SonKayýtId

alter proc sp_MusteriEkle
@Adi varchar(20),
@Soyadi varchar(20),
@Telefon varchar(20),
@Adres varchar(100),
@Sonuc bit output
as
if exists(select * from Musteriler where Adi=@Adi and Soyadi=@Soyadi)
begin
	print 'Bu müþteri zaten kayýtlý'
	set @Sonuc = 0
	return 
end
else
begin
	insert into Musteriler(Adi, Soyadi, Telefon, Adres) values(@Adi, @Soyadi, @Telefon, @Adres)
	set @Sonuc = 1
end
go

declare @Durum bit
exec sp_MusteriEkle
@Adi='Hidayet',
@Soyadi='Güleç',
@Telefon='5421111111',
@Adres='Þiþli-Ýstanbul',
@Sonuc=@Durum output
if(@Durum=1)
begin
 print 'Müþteri bilgileri kayýt edildi'
end
else
begin
 print 'Müþteri kayýt edilmedi'
end
