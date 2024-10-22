--Transact Sql (T-Sql)
--T-Sql i�inde yeni nesneler tan�mlama, verileri i�leme, sorgulama ve kullan�c� takibiyle ilgili kod bloklar�, mekanizmalar bulunmaktad�r.
--DDL (Data Definition Language - Veri Tan�mlama Dili)
--Create nesnead� -> Yeni nesne olu�turmak i�in kullan�l�r.
--Alter nesnead�  -> Varolan nesneler �zerinde de�i�iklik yapmak i�in kullan�l�r.
--Drop nesnead�   -> �smi belirtilen nesneyi silmek i�in kullan�l�r.

use master
go

create database DenemeDb
go
use DenemeDb	--DenemeDb veritaban� aktif hale gelir.
go
create table DeneTable1		--Aktif veritaban� i�inde (DenemeDb) DeneTable1 ad�nda yeni bir tablo olu�turur.
(
	Id int primary key identity(1,1) not null,
	DeneName varchar(50) not null
)

alter table DeneTable1	--DeneTable1 tablosu �zerinde de�i�iklik yapmak istedi�imizi belirtir.
add Description varchar(max) --yeni bir kolon ekler.

drop table DeneTable1  --�smi verilen tabloyu siler.

use master
go
drop database DenemeDb --�smi verilen veritaban�n� siler.

--Genel Veritaban� Tan�mlama �rne�i
use master
go
create database YeniData on
Primary (Name='YeniData', FileName='C:\Bright\Drives\E\YeniData.mdf',
		 Size=10, MaxSize=100, FileGrowth=10),
FileGroup Secondary
		(Name='YeniData2', FileName='C:\Bright\Drives\F\YeniData2.ndf',
		 Size=10, MaxSize=100, FileGrowth=20%)
log on (Name='YeniData_log', FileName='C:\Bright\Drives\E\YeniData.ldf',
		 Size=4, FileGrowth=40%)
collate Turkish_CI_AS

alter database YeniData
add filegroup Third

alter database YeniData
add file(Name='YeniData3', FileName='C:\Bright\Drives\G\YeniData3.ndf',
		 Size=10, MaxSize=100, FileGrowth=20%) 
		 to filegroup Third
go

use YeniData
go
create table YeniTablo1
(
	Id int primary key identity(1,1),
	Ad varchar(20) not null,
	Soyad varchar(20) not null
)