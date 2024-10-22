--TRIGGERS (Tetikleyiciler)
--Tigger'lar tablolar üzerine kayýt edilirler ve tablo üzerindeki insert, update, delete iþlemlerinde otomatik olarak tetiklenirler (çalýþýrlar).
--Doðrudan çalýþtýrýlamazlar.
--Insert iþleminden sonra otomatik olarak inserted tablosu, Delete iþleminden sonra deleted tablosu oluþturulur. Eklenen kayýt yada kayýtlar inserted tablosuna, silinen kayýt yada kayýtlar deleted tablosuna kayýt edilirler.
--Update iþleminde ise hem deleted hem de inserted tablosu oluþur. Silinen orjinal bilgiler (before image) deleted tablosuna, eklenen yeni bilgiler (after image) ise inserted tablosuna kayýt edilir.
--Trigger'lar FOR (AFTER) Triggers ve INSTEAD OF Triggers olmak üzere 2 farklý þekilde çalýþýrlar.

--FOR (AFTER) Triggers  (Öncelikle insert, update, delete iþlemleri gerçekleþir, ardýndan for trigger'lar devreye girer, istenilirse tüm iþlemler rollback ile geriye alýnabilir.)

--Create trigger Ýsim
--on TabloAdý
--for triggerolayý (insert, update, delete)
--as
--T-Sql kodlarý...
--rollback

use MovieMarket
go

--Müþteriler tablosundan ayný anda birden fazla müþteri silinmesine izin vermeyen trigger kodlarýný yazýnýz.

create trigger Tg_CokluSilme
on Musteriler
for delete
as
if(select count(*) from deleted) > 1
	begin
		print 'Ayný anda birden fazla müþteri silemezsiniz!'
		rollback
		return
	end
go

select * from Musteriler where Id>=12 
delete from Musteriler where Id>=12  --Öncelikle 12 ve 13 id'li müþteriler siliniyor. Ardýndan trigger devreye giriyor ve birden fazla müþteri silindiði için iþlemler rollback ile geri alýnýyor.

delete from Musteriler where Id>12  --Tek bir müþteri kaydý silindiði için trigger devreye girdi ancak þart saðlanmadýðýndan rollback çalýþmadý.

alter trigger Tg_CokluSilme
on Musteriler
for delete
as
if(select count(*) from deleted) > 0
	begin
		--print 'Yetkiniz yok, müþteri silemezsiniz!'
		raiserror('Yetkiniz yok, müþteri silemezsiniz!', 16, 1) --50000'li kullanýcý tanýmlý hata kodlarý fýrlatýlýyor. 
		rollback
		return
	end
go

delete from Musteriler where Id=12

alter table Musteriler
disable trigger tg_CokluSilme  --Trigger devre dýþý kalýr, silme iþlemleri kontrol edilmez.

alter table Musteriler
enable trigger tg_CokluSilme  --Trigger yeniden devreye alýnýr, silme iþlemleri kontrol edilmeye baþlanýr.

alter table Filmler
add Miktar int not null default 20

select * from Filmler

--Film satýþý gerçekleþtiðinde filmin stok miktarýný satýþ adedi kadar eksilten trigger kodlarýný yazýnýz.
create trigger Tg_FilmSatildi
on FilmSatis
for insert
as
declare @Adet int
declare @FilmId int
select @FilmId = FilmId, @Adet= Adet from inserted
update Filmler set Miktar=Miktar - @Adet where Id=@FilmId
go

insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(11, 4, 5, 125)

select * from FilmSatis
select * from Filmler

alter trigger Tg_FilmSatildi
on FilmSatis
for insert
as
update Filmler set Miktar=Miktar - inserted.Adet from Filmler inner join inserted on Filmler.Id = inserted.FilmId
--where Filmler.Id = inserted.FilmId
go

insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(5, 3, 3, 140)

select * from FilmSatis
select * from Filmler

--Önceden yapýlan 29 nolu satýþta satýþ adedi yanlýþlýkla 5 girilmiþ, 3 olarak düzeltilmesi isteniyor. Bu durumda satýlan filmin stok miktarýný düzenleyen trigger kodlarýný yazýnýz.

update FilmSatis set Adet=3 where Id=29

create trigger Tg_SatisDuzeltme
on FilmSatis
for Update
as
update Filmler set Miktar += deleted.Adet from Filmler inner join deleted on Filmler.Id = deleted.FilmId
update Filmler set Miktar -= inserted.Adet from Filmler inner join inserted on Filmler.Id = inserted.FilmId
go

alter trigger Tg_SatisDuzeltme
on FilmSatis
for Update
as
update Filmler set Miktar += deleted.Adet - inserted.Adet from Filmler inner join deleted on Filmler.Id = deleted.FilmId inner join inserted on Filmler.Id = inserted.FilmId
go

update FilmSatis set Adet=8 where Id=30

--Satýþ sonrasý satýlan filmin stok miktarý 0 yada altýna düþerse filmin stokta kalmadýðýný yada satýþýnýn devam edemeyeceðini (Varmi=0) tanýmlayan trigger kodlarýný yazýnýz.

--Instead Of Triggers 
--Bu trigger'lar kýsýtlayýcýlar (constraints) gibi çalýþýr, yani belirtilen iþlem yerine trigger'daki kodlar çalýþmýþ olur.
--Yine de inserted ve deleted dosyalarý oluþturulur.

Alter table Musteriler
Add Silindi bit default 0 not null

create trigger Tg_MusteriSilme
on Musteriler
instead of delete
as
update Musteriler set Silindi=1  from Musteriler inner join deleted on Musteriler.Id = deleted.Id
go

delete from Musteriler where Id=1