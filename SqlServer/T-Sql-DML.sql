--T-SQL
--DML (Data Manipulation Language - Veri Ýþleme Dili)
--Select -> veri seçmek, listelemek için kullanýlýr.
--Insert -> veri eklemek için kullanýlýr.
--Update -> veriler üzerinde deðiþiklik, güncelleme yapmak için kullanýlýr.
--Delete -> istenilen verilerin silinmesi için kullanýlýr.

--Select [kolonadlarý] From TabloAdý [Where Þartlar]

use OrnekDb
go
select Name, Age from Table_1	--F5 veya Execute ile (tercihen seçili) kod satýrlarýný çalýþtýrýyoruz.
select Id, TCKNo, Name from Table_1
select * from Table_1	-- * operatörü ile tablodaki tüm kolonlar orijinal sýrasýnda listelenir.
select * from Table_1 where Age<30		-- == yerine =, != veya <> ikisi de geçerli.

--Movie Market veritabaný
use master
go
create database MovieMarket
go
use MovieMarket		--MovieMarket veritabanýný aktif hale getirir.
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
--Kayýt (record) Ekleme (Insert)
--Insert into TabloAdý [(KolonAdý1, KolonAdý2,...)] values(Deðer1, Deðer2, ...)
insert into FilmTurleri values('Dram', 'Acýlý, hüzünlü, dramatik')
insert into FilmTurleri values('Komedi', 'Komik, neþeli, eðlenceli')
insert into FilmTurleri values('Romantik Komedi', 'Hem komik, hem romantik, eðlenceli')
select * from FilmTurleri
insert into FilmTurleri(TurAdi) values('Korku, Gerilim')
go
insert into FilmTurleri values('Savaþ', 'Tarihi savaþ ve aksiyon')
insert into FilmTurleri values('Bilim Kurgu', 'Fantastik, robot, yapay zeka')
go
insert into FilmTurleri(TurAdi) values('Aksiyon, Gerilim')
go
insert into Filmler(FilmAdi, TurId, Yonetmen, Oyuncular, Ozet, YapimYili) values('Baskýn', 7, 'Gareth Evans', 'Ananda George, Donny Alamsyah', 'Operasyon timinin uyuþturucu baskýnlarý', '10.10.2011')
go
insert into Filmler(FilmAdi, TurId, Yonetmen, Oyuncular, Ozet, YapimYili) values('Truva', 5, 'Wolfgan Pettersen', 'Bradd Pitt, Orlando Bloom', 'Eski çaðlarda ünlü truva savaþýndan kesitler', '10.10.2004')
insert into Filmler(FilmAdi, TurId, Yonetmen, Oyuncular, Ozet, YapimYili) values('Titanic', 1, 'James Cameron', 'Leonardo Di Caprio, Cate Winslet', 'Lüks Titanic gemisinin hazin öyküsü', '10.10.1997')
insert into Filmler(FilmAdi, TurId, Yonetmen, Oyuncular, Ozet, YapimYili) values('Fight Club', 1, 'David Lyinch', 'Bradd Pitt, Edward Norton', 'Dövüþ kulübü, ilk kural bahsetmemek', '10.10.1999')
insert into Filmler(FilmAdi, TurId, Yonetmen, Oyuncular, Ozet, YapimYili) values('Soysuzlar Çetesi', 5, 'Quantin Tarantino', 'Bradd Pitt, Christoph Wals', '2.Dünya savaþýndan kesitler', '05.05.2009')
select * from Filmler
insert into Musteriler values('Ali', 'Uçar', '2122578987', 'Beþiktaþ-Ýstanbul')
insert into Musteriler values('Oya', 'Sever', '2125704987', 'Bakýrköy-Ýstanbul')
insert into Musteriler values('Ayþe', 'Koþar', '2163454647', 'Kadýköy-Ýstanbul')
insert into Musteriler values('Neþe', 'Coþar', '2163576987', 'Üsküdar-Ýstanbul')
select * from Musteriler
--Savaþ (5) türünden filmlerin adý, yönetmeni ve oyuncularýný listeleyen sorguyu yazýnýz.
select FilmAdi, Yonetmen, Oyuncular from Filmler where TurId=5

--Dram (1) türünden filmlerin tüm bilgilerini listeleyen sorguyu yazýnýz.
select * from Filmler where TurId=1

--Yönetmeni James Cameron olan filmleri listeleyen sorguyu yazýnýz.
select * from Filmler where Yonetmen='James Cameron'

--Stokta mevcut olan filmlerin Id ve isimlerini listeleyen sorguyu yazýnýz.
select Id, FilmAdi from Filmler where Varmi=1

--Kayýtlarda deðiþiklik-güncelleme (Update)
--Update TabloAdý Set KolonAdý=YeniDeðer, ... where þart
update FilmTurleri set Aciklama='Heyecan fýrtýnasý' where Id=7

--Dram (1) türü filmleri stokta kalmadý olarak iþaretleyen sorguyu yazýnýz.
select * from Filmler where TurId=1
update Filmler set varmi=0 where TurId=1

--Satýþ tablolarý hareket tablolarýna örnek olup, mümkün olduðunca dinamik ve küçük boyutlu tablolar olmalýdýr.
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

--Tarih Sorgulamalarý
Select getdate() as GününTarihi

select convert(nvarchar(20), getdate(), 106)  --09 Jul 2023
select convert(nvarchar(20), getdate(), 105)  --09-07-2023
select convert(nvarchar(20), getdate(), 104)  --09.07.2023
select convert(nvarchar(20), getdate(), 103)  --09/07/2023
select convert(nvarchar(20), getdate(), 102)  --2023.07.09
select convert(nvarchar(20), getdate(), 101)  --07/09/2023
select convert(nvarchar(20), getdate(), 100)  --Jul 9 2023 12:26PM

--08.05.2023 tarihinde yapýlan satýþlarý listeleyen sorgu.
--select * from FilmSatis where Tarih >= '08.05.2023' and Tarih <= '09.05.2023'  --karakter kabul ettiðinden hatalý sonuç veriyor.
select * from FilmSatis where Tarih >= '2023.05.08' and Tarih <= '2023.05.09'
select * from FilmSatis where Convert(nvarchar(20), Tarih, 104) = '08.05.2023' --sol tarafý 08.05.2023 formatýna çevirdik.

--Haziran ayýndaki satýþlarý listeleyen sorgu.
select * from FilmSatis where Tarih >= '2023.06.01' and Tarih <= '2023.06.30'

insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(4,3,1,160)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(3,2,2,125)

--Bugün yapýlan satýþlarý listeleyen sorgu.
select * from FilmSatis where Convert(Date, Tarih, 104) = Convert(Date, getdate(), 104)  --Her iki taraftan gelen tarih formatý ayný olduðundan, saatlerden kurtardýðý için doðru sonucu elde ediyoruz.

select * from FilmSatis where Convert(nvarchar(20), Tarih, 104) = Convert(nvarchar(20), getdate(), 104) --Tavsiye edilen 

--insert into FilmSatis(Tarih, FilmId, MusteriId, Adet, BirimFiyat) values('09.07.2023',3,2,2,125) --veritabanýna kayýt edilirken Sql yine yyyy.aa.gg formatýna çeviriyor.

--Temmuz ayýndaki satýþlarý listeleyen sorgu.
select * from FilmSatis where Tarih >= '2023.07.01' and Tarih <= '2023.07.31'
select * from FilmSatis where Tarih Between '2023.07.01' and '2023.07.31'

select * from FilmSatis where Convert(nvarchar(20),Tarih, 104) Between '01.07.2023' and '31.07.2023' --sað taraf karakter olarak algýlandýðýndan tarih aralýðý doðru bulunamýyor.

select * from FilmSatis where Convert(Date,Tarih, 104) Between Convert(Date,'01.07.2023', 104) and Convert(Date,'31.07.2023', 104) --Tavsiye edilen garantili çözüm
