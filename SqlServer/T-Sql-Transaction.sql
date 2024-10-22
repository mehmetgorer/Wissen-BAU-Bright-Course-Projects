--TRANSACTION

--Birden fazla i�lem blo�u bir transaction i�inde takip edilebilir.

--Transaction blo�u Begin Transaction ile ba�lar, Commit Transaction ile onaylan�r yada Rollback Transaction ile i�lemler geriye al�n�r.

--�zellikle bankac�l�k ve online rezervasyon gibi alanlarda olduk�a fazla kullan�l�r.

--ABank ve BBank ad�nda iki tablodan olu�an bir Bankalar veritaban�m�z olsun. ABank'tan �ekilen paran�n BBank'taki bir hesaba g�venli bir �ekilde aktar�lmas�n� kontrol eden transaction yap�s�n� kurunuz.

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
	Rollback transaction Transfer1 --��lemleri geri al�r.
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
	Commit tran		--��lemler onaylan�r.