--TRANSACTION

--Birden fazla iþlem bloðu bir transaction içinde takip edilebilir.

--Transaction bloðu Begin Transaction ile baþlar, Commit Transaction ile onaylanýr yada Rollback Transaction ile iþlemler geriye alýnýr.

--Özellikle bankacýlýk ve online rezervasyon gibi alanlarda oldukça fazla kullanýlýr.

--ABank ve BBank adýnda iki tablodan oluþan bir Bankalar veritabanýmýz olsun. ABank'tan çekilen paranýn BBank'taki bir hesaba güvenli bir þekilde aktarýlmasýný kontrol eden transaction yapýsýný kurunuz.

use master
go
create database Bankalar
go
use Bankalar
go
create table ABank
(
	A_Id int primary key identity(1, 1),
	A_HesapId int not null,
	A_Tutar money not null default 0
)
go
create table BBank
(
	B_Id int primary key identity(1, 1),
	B_HesapId int not null,
	B_Tutar money not null default 0
)
go
insert into ABank values(1001, 5000)
insert into ABank values(1002, 8000)
insert into ABank values(1003, 12000)
insert into ABank values(1004, 15000)
select * from ABank

insert into BBank values(2001, 5000)
insert into BBank values(2002, 8000)
insert into BBank values(2003, 12000)
insert into BBank values(2004, 15000)
select * from BBank

--ABank 1003 nolu hesaptan BBank 2003 nolu hesaba 4000 TL. aktarmak istiyoruz.

Begin Transaction Transfer1
declare @cekilenHesap int = 1003
declare @yatirilanHesap int = 1003
declare @tutar money = 4000
update ABank set A_Tutar -= @tutar where A_HesapId = @cekilenHesap
update BBank set B_Tutar += @tutar where B_HesapId = @yatirilanHesap
if not exists(select * from BBank where B_HesapId = @yatirilanHesap)
	Rollback transaction Transfer1 --Ýþlemleri geri alýr.
else
	Commit tran		

select * from ABank
select * from BBank

Begin Transaction Transfer2
declare @cekilenHesap int = 1003
declare @yatirilanHesap int = 2003
declare @tutar money = 4000
update ABank set A_Tutar -= @tutar where A_HesapId = @cekilenHesap
update BBank set B_Tutar += @tutar where B_HesapId = @yatirilanHesap
if not exists(select * from BBank where B_HesapId = @yatirilanHesap)
	Rollback tran	
else
	Commit tran		--Ýþlemler onaylanýr.