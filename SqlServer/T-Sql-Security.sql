--Sql Server G�venlik ve Yetkilendirme

--Windows Authentication    --> Mixed Mode (ikisi birden)
--Sql Server Authentication	--> sa-> password

--Login Authentication  (SSMS - Security - Login)
--Database Permission

--Server Roles
--En yetkili role -> sysadmin, s�n�rl� login yetkisine sahip olan public

--�ncelikle login i�in bir kullan�c� tan�ml�yoruz. 
--SSMS - Security - Login - New Login se�ti�imizde gelen ekranda kullan�c� ad� (dene1) vererek yeni bir login kullan�c�s� tan�mlad�k.
--Default olarak public server rol�ne sahip oldu�undan veritabanlar�yla i�lem yapam�yor, ancak User Mapping se�ene�inden Bankalar veritaban� i�in db_datareader database rol� verdi�imizden sadece bu veritaban� i�in select i�lemlerini ger�ekle�tirebiliyor.

--Database Roles
--Herhangi bir veritaban�n�n alt�ndaki security-Roles-Database Roles alt�ndaki roller.
--En yetkili db_owner, db_datareader select yetkisi, db_datawriter insert, update,delete yetkisi veriyor.

--Application Roles
--�zel yetkilendirme yap�labilen, kullan�c�larla ili�kilendirilebilen roller.

--Securables, Sql Server nesnelerini kullanabilmek i�in verilen yetkileri, Permissions ise bu nesneler �zerinde i�lem yapabilme yetkilerini d�zenler.

--DCL - (Data Control Language)
--DCL, User ve Rollerle ilgili yetkilendirme ve k�s�tlamalar� y�netmek i�in kullan�l�r.
--Grant -> Yetki vermek i�in,
--Deny  -> Yetki k�s�tlamak i�in,
--Revoke -> Verilen bir yetki veya k�s�tlamay� kald�rmak i�in kullan�l�r.

--�ncelikle bir login kullan�c� hesab� a��yoruz.

--create login isim with password='***'

use master
go
create login ornekUser1 with password='1'

--Tan�mlad���m�z login hesab� �zerinden veritabanlar�nda kullan�lmak �zere kullan�c� hesab� (User) tan�ml�yoruz.
--Sql'e sa ile ba�lan�yoruz.
use MovieMarket
go
create user ornekUser1
from login ornekUser1

--grant all|izinler
--on nesneler to hesapad�

grant select on Filmler to ornekUser1

sp_helprotect 'Filmler'

select Current_User

select * from Filmler
select * from Musteriler	--Yetki yok hatas� al�yoruz.

--sa ile ba�lan�yoruz.
--�ncelikle ana Security sekmesi alt�nda login yetkisinde kullan�c�lar tan�ml�yoruz.

use master
go
create login ornekUser2 with password='2'
go
create login ornekUser3 with password='3'
go

--Ard�ndan veritaban�nda kullanmak �zere tan�ml� login hesaplardan database user'lar tan�ml�yoruz.

use MovieMarket
go				--MovieMarket aktif hale geliyor.
create user ornekUser2	--kullan�c�lar aktif veritaban� �zerinde 
from login ornekUser2	--tan�mlan�yor.
go
create user ornekUser3
from login ornekUser3

--Grant With -> Yetki verebilme yetkisi verir.
grant select on musteriler to ornekUser1
with grant option

sp_helprotect 'musteriler'

use MovieMarket
go
grant select on musteriler to ornekUser2  --ornekUser1, �ncesinde with grant option ile yetki aktarabilme yetkisi ald���ndan i�lem hatas�z �al���yor ve ornekUser2 kullan�c�s�na select yetkisi veriliyor.

--ROLE Tan�mlama

--sa kullan�c�s�n� aktif hale getiriyoruz.
--Aktif veritaban�nda yeni bir database rol� a�a��daki gibi tan�mlan�r:

use MovieMarket
go
create role Satis authorization dbo

grant select on FilmSatis to Satis --Satis rol�ne FilmSatis tablosunda select ile sorgulama yetkisi verildi.

--sp_addrolemember 'db_datareader', 'ornekUser2'
Exec sp_addrolemember 'Satis', 'ornekUser3'  --ornekUser3 kullan�c�s� Satis rol�yle ili�kilendirildi.
use MovieMarket
go
select * from FilmSatis

select Current_User

--sp_addrolemember 'db_datawriter', 'Satis' --Satis rol�ne verilecek yetkiler dolayl� olarak bu rol� kullanan user hesaplar� da etkileyecektir.

--��lem K�s�tlama

--Deny All|izinler to kullan�c�lar

--Belirtilen i�lemlerle ilgili kullan�c�lara k�s�tlama getirir.

--Deny create database to dene1
use MovieMarket
go
deny insert on FilmTurleri to ornekUser2

--�zin yada K�s�tlamalar� Kald�rma
--Revoke ALL|�zinler on nesne to hesaplar Cascade

Revoke select on FilmSatis to ornekUser3  --ornekUser3 kullan�c�s�n�n FilmSatis tablosundan select yetkisini kald�r�yoruz.

sp_helprotect 'FilmSatis' 

use MovieMarket
go
select Current_User  --ornekUser3

select * from FilmSatis  --Sat�� listesini alabildik, bunun nedeni ornekUser3 kendisinde olmamas�na ra�men dahil oldu�u Satis rol�n�n yetkileri dolayl� olarak kullan�yor.

--Revoke ile Deny aras�ndaki fark, Revoke ile kullan�c�n�n do�rudan eri�im haklar� kald�r�l�r ancak dolayl� olarak ba�ka rollerden eri�im hakk�na sahip olabilir.
--DENY kullan�l�rsa, kullan�c� otomatik olarak art�k o nesneye eri�emez.








