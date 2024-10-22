--T-SQL
--DML (Data Manipulation Language - Veri ��leme Dili)
--Select -> veri se�mek, listelemek i�in kullan�l�r.
--Insert -> veri eklemek i�in kullan�l�r.
--Update -> veriler �zerinde de�i�iklik, g�ncelleme yapmak i�in kullan�l�r.
--Delete -> istenilen verilerin silinmesi i�in kullan�l�r.

--Select [kolonadlar�] From TabloAd� [Where �artlar]

use OrnekDb
go
select Name, Age from Table_1	--F5 veya Execute ile (tercihen se�ili) kod sat�rlar�n� �al��t�r�yoruz.
select Id, TCKNo, Name from Table_1
select * from Table_1	-- * operat�r� ile tablodaki t�m kolonlar orijinal s�ras�nda listelenir.
select * from Table_1 where Age<30		-- == yerine =, != veya <> ikisi de ge�erli.

--Movie Market veritaban�
use master
go
create database MovieMarket
go
use MovieMarket		--MovieMarket veritaban�n� aktif hale getirir.
go
create table FilmTurleri
(
	Id int primary key identity(1, 1),
	TurAdi varchar(20) not null,
	Aciklama varchar(100)
)
go
create table Filmler
(
	Id int primary key identity(1, 1),
	FilmAdi varchar(20) not null,
	TurId int not null,
	Yonetmen varchar(100),
	Oyuncular varchar(200),
	Ozet varchar(max),
	YapimYili Date,
	Varmi bit not null default 1
)
go
create table Musteriler
(
	Id int primary key identity(1,1),
	Adi varchar(20) not null,
	Soyadi varchar(20) not null,
	Telefon varchar(20),
	Adres varchar(100)
)
go
select * from Filmler
--Kay�t (record) Ekleme (Insert)
--Insert into TabloAd� [(KolonAd�1, KolonAd�2,...)] values(De�er1, De�er2, ...)
insert into FilmTurleri values('Dram', 'Ac�l�, h�z�nl�, dramatik')
insert into FilmTurleri values('Komedi', 'Komik, ne�eli, e�lenceli')
insert into FilmTurleri values('Romantik Komedi', 'Hem komik, hem romantik, e�lenceli')
select * from FilmTurleri
insert into FilmTurleri(TurAdi) values('Korku, Gerilim')
go
insert into FilmTurleri values('Sava�', 'Tarihi sava� ve aksiyon')
insert into FilmTurleri values('Bilim Kurgu', 'Fantastik, robot, yapay zeka')
go
insert into FilmTurleri(TurAdi) values('Aksiyon, Gerilim')
go
insert into Filmler(FilmAdi, TurId, Yonetmen, Oyuncular, Ozet, YapimYili) values('Bask�n', 7, 'Gareth Evans', 'Ananda George, Donny Alamsyah', 'Operasyon timinin uyu�turucu bask�nlar�', '10.10.2011')
go
insert into Filmler(FilmAdi, TurId, Yonetmen, Oyuncular, Ozet, YapimYili) values('Truva', 5, 'Wolfgan Pettersen', 'Bradd Pitt, Orlando Bloom', 'Eski �a�larda �nl� truva sava��ndan kesitler', '10.10.2004')
insert into Filmler(FilmAdi, TurId, Yonetmen, Oyuncular, Ozet, YapimYili) values('Titanic', 1, 'James Cameron', 'Leonardo Di Caprio, Cate Winslet', 'L�ks Titanic gemisinin hazin �yk�s�', '10.10.1997')
insert into Filmler(FilmAdi, TurId, Yonetmen, Oyuncular, Ozet, YapimYili) values('Fight Club', 1, 'David Lyinch', 'Bradd Pitt, Edward Norton', 'D�v�� kul�b�, ilk kural bahsetmemek', '10.10.1999')
insert into Filmler(FilmAdi, TurId, Yonetmen, Oyuncular, Ozet, YapimYili) values('Soysuzlar �etesi', 5, 'Quantin Tarantino', 'Bradd Pitt, Christoph Wals', '2.D�nya sava��ndan kesitler', '05.05.2009')
select * from Filmler
insert into Musteriler values('Ali', 'U�ar', '2122578987', 'Be�ikta�-�stanbul')
insert into Musteriler values('Oya', 'Sever', '2125704987', 'Bak�rk�y-�stanbul')
insert into Musteriler values('Ay�e', 'Ko�ar', '2163454647', 'Kad�k�y-�stanbul')
insert into Musteriler values('Ne�e', 'Co�ar', '2163576987', '�sk�dar-�stanbul')
select * from Musteriler
--Sava� (5) t�r�nden filmlerin ad�, y�netmeni ve oyuncular�n� listeleyen sorguyu yaz�n�z.
select FilmAdi, Yonetmen, Oyuncular from Filmler where TurId=5

--Dram (1) t�r�nden filmlerin t�m bilgilerini listeleyen sorguyu yaz�n�z.
select * from Filmler where TurId=1

--Y�netmeni James Cameron olan filmleri listeleyen sorguyu yaz�n�z.
select * from Filmler where Yonetmen='James Cameron'

--Stokta mevcut olan filmlerin Id ve isimlerini listeleyen sorguyu yaz�n�z.
select Id, FilmAdi from Filmler where Varmi=1

--Kay�tlarda de�i�iklik-g�ncelleme (Update)
--Update TabloAd� Set KolonAd�=YeniDe�er, ... where �art
update FilmTurleri set Aciklama='Heyecan f�rt�nas�' where Id=7

--Dram (1) t�r� filmleri stokta kalmad� olarak i�aretleyen sorguyu yaz�n�z.
select * from Filmler where TurId=1
update Filmler set varmi=0 where TurId=1

--Sat�� tablolar� hareket tablolar�na �rnek olup, m�mk�n oldu�unca dinamik ve k���k boyutlu tablolar olmal�d�r.
Create Table FilmSatis
(
	Id int primary key identity(1,1),
	Tarih DateTime not null default getdate(),
	FilmId int not null,
	MusteriId int not null,
	Adet int not null,
	BirimFiyat money not null
)
go
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(1,1,2,120)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(2,1,1,130)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(5,3,4,90)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(4,2,3,110)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(3,4,2,100)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(1,2,5,80)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(3,3,2,150)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(5,4,1,140)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(2,3,4,110)
go
select * from FilmSatis

--Tarih Sorgulamalar�
Select getdate() as G�n�nTarihi

select convert(nvarchar(20), getdate(), 106)  --09 Jul 2023
select convert(nvarchar(20), getdate(), 105)  --09-07-2023
select convert(nvarchar(20), getdate(), 104)  --09.07.2023
select convert(nvarchar(20), getdate(), 103)  --09/07/2023
select convert(nvarchar(20), getdate(), 102)  --2023.07.09
select convert(nvarchar(20), getdate(), 101)  --07/09/2023
select convert(nvarchar(20), getdate(), 100)  --Jul 9 2023 12:26PM

--08.05.2023 tarihinde yap�lan sat��lar� listeleyen sorgu.
--select * from FilmSatis where Tarih >= '08.05.2023' and Tarih <= '09.05.2023'  --karakter kabul etti�inden hatal� sonu� veriyor.
select * from FilmSatis where Tarih >= '2023.05.08' and Tarih <= '2023.05.09'
select * from FilmSatis where Convert(nvarchar(20), Tarih, 104) = '08.05.2023' --sol taraf� 08.05.2023 format�na �evirdik.

--Haziran ay�ndaki sat��lar� listeleyen sorgu.
select * from FilmSatis where Tarih >= '2023.06.01' and Tarih <= '2023.06.30'

insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(4,3,1,160)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(3,2,2,125)

--Bug�n yap�lan sat��lar� listeleyen sorgu.
select * from FilmSatis where Convert(Date, Tarih, 104) = Convert(Date, getdate(), 104)  --Her iki taraftan gelen tarih format� ayn� oldu�undan, saatlerden kurtard��� i�in do�ru sonucu elde ediyoruz.

select * from FilmSatis where Convert(nvarchar(20), Tarih, 104) = Convert(nvarchar(20), getdate(), 104) --Tavsiye edilen 

--insert into FilmSatis(Tarih, FilmId, MusteriId, Adet, BirimFiyat) values('09.07.2023',3,2,2,125) --veritaban�na kay�t edilirken Sql yine yyyy.aa.gg format�na �eviriyor.

--Temmuz ay�ndaki sat��lar� listeleyen sorgu.
select * from FilmSatis where Tarih >= '2023.07.01' and Tarih <= '2023.07.31'
select * from FilmSatis where Tarih Between '2023.07.01' and '2023.07.31'

select * from FilmSatis where Convert(nvarchar(20),Tarih, 104) Between '01.07.2023' and '31.07.2023' --sa� taraf karakter olarak alg�land���ndan tarih aral��� do�ru bulunam�yor.

select * from FilmSatis where Convert(Date,Tarih, 104) Between Convert(Date,'01.07.2023', 104) and Convert(Date,'31.07.2023', 104) --Tavsiye edilen garantili ��z�m
