--Sql Server Güvenlik ve Yetkilendirme

--Windows Authentication    --> Mixed Mode (ikisi birden)
--Sql Server Authentication	--> sa-> password

--Login Authentication  (SSMS - Security - Login)
--Database Permission

--Server Roles
--En yetkili role -> sysadmin, sýnýrlý login yetkisine sahip olan public

--Öncelikle login için bir kullanýcý tanýmlýyoruz. 
--SSMS - Security - Login - New Login seçtiðimizde gelen ekranda kullanýcý adý (dene1) vererek yeni bir login kullanýcýsý tanýmladýk.
--Default olarak public server rolüne sahip olduðundan veritabanlarýyla iþlem yapamýyor, ancak User Mapping seçeneðinden Bankalar veritabaný için db_datareader database rolü verdiðimizden sadece bu veritabaný için select iþlemlerini gerçekleþtirebiliyor.

--Database Roles
--Herhangi bir veritabanýnýn altýndaki security-Roles-Database Roles altýndaki roller.
--En yetkili db_owner, db_datareader select yetkisi, db_datawriter insert, update,delete yetkisi veriyor.

--Application Roles
--Özel yetkilendirme yapýlabilen, kullanýcýlarla iliþkilendirilebilen roller.

--Securables, Sql Server nesnelerini kullanabilmek için verilen yetkileri, Permissions ise bu nesneler üzerinde iþlem yapabilme yetkilerini düzenler.

--DCL - (Data Control Language)
--DCL, User ve Rollerle ilgili yetkilendirme ve kýsýtlamalarý yönetmek için kullanýlýr.
--Grant -> Yetki vermek için,
--Deny  -> Yetki kýsýtlamak için,
--Revoke -> Verilen bir yetki veya kýsýtlamayý kaldýrmak için kullanýlýr.

--Öncelikle bir login kullanýcý hesabý açýyoruz.

--create login isim with password='***'

use master
go
create login ornekUser1 with password='1'

--Tanýmladýðýmýz login hesabý üzerinden veritabanlarýnda kullanýlmak üzere kullanýcý hesabý (User) tanýmlýyoruz.
--Sql'e sa ile baðlanýyoruz.
use MovieMarket
go
create user ornekUser1
from login ornekUser1

--grant all|izinler
--on nesneler to hesapadý

grant select on Filmler to ornekUser1

sp_helprotect 'Filmler'

select Current_User

select * from Filmler
select * from Musteriler	--Yetki yok hatasý alýyoruz.

--sa ile baðlanýyoruz.
--Öncelikle ana Security sekmesi altýnda login yetkisinde kullanýcýlar tanýmlýyoruz.

use master
go
create login ornekUser2 with password='2'
go
create login ornekUser3 with password='3'
go

--Ardýndan veritabanýnda kullanmak üzere tanýmlý login hesaplardan database user'lar tanýmlýyoruz.

use MovieMarket
go				--MovieMarket aktif hale geliyor.
create user ornekUser2	--kullanýcýlar aktif veritabaný üzerinde 
from login ornekUser2	--tanýmlanýyor.
go
create user ornekUser3
from login ornekUser3

--Grant With -> Yetki verebilme yetkisi verir.
grant select on musteriler to ornekUser1
with grant option

sp_helprotect 'musteriler'

use MovieMarket
go
grant select on musteriler to ornekUser2  --ornekUser1, öncesinde with grant option ile yetki aktarabilme yetkisi aldýðýndan iþlem hatasýz çalýþýyor ve ornekUser2 kullanýcýsýna select yetkisi veriliyor.

--ROLE Tanýmlama

--sa kullanýcýsýný aktif hale getiriyoruz.
--Aktif veritabanýnda yeni bir database rolü aþaðýdaki gibi tanýmlanýr:

use MovieMarket
go
create role Satis authorization dbo

grant select on FilmSatis to Satis --Satis rolüne FilmSatis tablosunda select ile sorgulama yetkisi verildi.

--sp_addrolemember 'db_datareader', 'ornekUser2'
Exec sp_addrolemember 'Satis', 'ornekUser3'  --ornekUser3 kullanýcýsý Satis rolüyle iliþkilendirildi.
use MovieMarket
go
select * from FilmSatis

select Current_User

--sp_addrolemember 'db_datawriter', 'Satis' --Satis rolüne verilecek yetkiler dolaylý olarak bu rolü kullanan user hesaplarý da etkileyecektir.

--Ýþlem Kýsýtlama

--Deny All|izinler to kullanýcýlar

--Belirtilen iþlemlerle ilgili kullanýcýlara kýsýtlama getirir.

--Deny create database to dene1
use MovieMarket
go
deny insert on FilmTurleri to ornekUser2

--Ýzin yada Kýsýtlamalarý Kaldýrma
--Revoke ALL|Ýzinler on nesne to hesaplar Cascade

Revoke select on FilmSatis to ornekUser3  --ornekUser3 kullanýcýsýnýn FilmSatis tablosundan select yetkisini kaldýrýyoruz.

sp_helprotect 'FilmSatis' 

use MovieMarket
go
select Current_User  --ornekUser3

select * from FilmSatis  --Satýþ listesini alabildik, bunun nedeni ornekUser3 kendisinde olmamasýna raðmen dahil olduðu Satis rolünün yetkileri dolaylý olarak kullanýyor.

--Revoke ile Deny arasýndaki fark, Revoke ile kullanýcýnýn doðrudan eriþim haklarý kaldýrýlýr ancak dolaylý olarak baþka rollerden eriþim hakkýna sahip olabilir.
--DENY kullanýlýrsa, kullanýcý otomatik olarak artýk o nesneye eriþemez.








