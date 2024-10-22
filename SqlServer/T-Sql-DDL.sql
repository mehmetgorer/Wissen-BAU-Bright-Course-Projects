--Transact Sql (T-Sql)
--T-Sql içinde yeni nesneler tanýmlama, verileri iþleme, sorgulama ve kullanýcý takibiyle ilgili kod bloklarý, mekanizmalar bulunmaktadýr.
--DDL (Data Definition Language - Veri Tanýmlama Dili)
--Create nesneadý -> Yeni nesne oluþturmak için kullanýlýr.
--Alter nesneadý  -> Varolan nesneler üzerinde deðiþiklik yapmak için kullanýlýr.
--Drop nesneadý   -> Ýsmi belirtilen nesneyi silmek için kullanýlýr.

use master
go

create database DenemeDb
go
use DenemeDb	--DenemeDb veritabaný aktif hale gelir.
go
create table DeneTable1		--Aktif veritabaný içinde (DenemeDb) DeneTable1 adýnda yeni bir tablo oluþturur.
(
	Id int primary key identity(1,1) not null,
	DeneName varchar(50) not null
)

alter table DeneTable1	--DeneTable1 tablosu üzerinde deðiþiklik yapmak istediðimizi belirtir.
add Description varchar(max) --yeni bir kolon ekler.

drop table DeneTable1  --Ýsmi verilen tabloyu siler.

use master
go
drop database DenemeDb --Ýsmi verilen veritabanýný siler.

--Genel Veritabaný Tanýmlama Örneði
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