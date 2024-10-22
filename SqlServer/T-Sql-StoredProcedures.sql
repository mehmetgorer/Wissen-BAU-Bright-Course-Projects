--STORED PROCEDURES (Sakl� Yordamlar)

--T-Sql komutlar�yla program yaz�labilen sql nesneleridir.
--Uygulama yaz�l�mlar� taraf�ndan kullan�labilirler.
--Network trafi�ini azaltarak performans ve g�venli�i art�r�rlar.
--D��ar�dan parametre alabilirler (input), d��ar�ya sonu� (output) d�nd�rebilirler.

use MovieMarket
go

create procedure sp_FilmleriGetir
as
select FilmAdi, TurAdi, Yonetmen, Oyuncular from Filmler inner join FilmTurleri on Filmler.TurId = FilmTurleri.Id
go

Exec sp_FilmleriGetir

--SP kodlar� ilk �al��t�r�ld���nda bir �al��ma plan� (Execute Plan) olu�turulur. E�er sorgu sonucu de�i�kenlik g�steren dinamik bir yap�da de�ilse, bu b�y�k bir performans avantaj� sa�layacakt�r.

--Ancak sorgu s�kl�kla de�i�en dinamik bir yap�daysa SP i�inde recompile kullanmam�z gerekli olacakt�r.

alter procedure sp_FilmleriGetir
with recompile, encryption
as
select FilmAdi, TurAdi, Yonetmen, Oyuncular from Filmler inner join FilmTurleri on Filmler.TurId = FilmTurleri.Id
go

sp_helptext 'sp_FilmleriGetir'

--encryption �zelli�i olmadan �al��t�rd���m�zda kodlar tekrar g�r�n�r hale geliyor.
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

exec sp_MusteriEkle 'Eyyup', 'Albayrak', '5446756544', 'Arnavutk�y-�stanbul'

exec sp_MusteriEkle
@Adi='Hidayet',
@Soyadi='G�le�',
@Telefon='54253463635',
@Adres='Ka��thane-�stanbul'
select @@IDENTITY as SonKay�tId

alter proc sp_MusteriEkle
@Adi varchar(20),
@Soyadi varchar(20),
@Telefon varchar(20),
@Adres varchar(100),
@Sonuc bit output
as
if exists(select * from Musteriler where Adi=@Adi and Soyadi=@Soyadi)
begin
	print 'Bu m��teri zaten kay�tl�'
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
@Soyadi='G�le�',
@Telefon='5421111111',
@Adres='�i�li-�stanbul',
@Sonuc=@Durum output
if(@Durum=1)
begin
 print 'M��teri bilgileri kay�t edildi'
end
else
begin
 print 'M��teri kay�t edilmedi'
end
