--TRIGGERS (Tetikleyiciler)
--Tigger'lar tablolar �zerine kay�t edilirler ve tablo �zerindeki insert, update, delete i�lemlerinde otomatik olarak tetiklenirler (�al���rlar).
--Do�rudan �al��t�r�lamazlar.
--Insert i�leminden sonra otomatik olarak inserted tablosu, Delete i�leminden sonra deleted tablosu olu�turulur. Eklenen kay�t yada kay�tlar inserted tablosuna, silinen kay�t yada kay�tlar deleted tablosuna kay�t edilirler.
--Update i�leminde ise hem deleted hem de inserted tablosu olu�ur. Silinen orjinal bilgiler (before image) deleted tablosuna, eklenen yeni bilgiler (after image) ise inserted tablosuna kay�t edilir.
--Trigger'lar FOR (AFTER) Triggers ve INSTEAD OF Triggers olmak �zere 2 farkl� �ekilde �al���rlar.

--FOR (AFTER) Triggers  (�ncelikle insert, update, delete i�lemleri ger�ekle�ir, ard�ndan for trigger'lar devreye girer, istenilirse t�m i�lemler rollback ile geriye al�nabilir.)

--Create trigger �sim
--on TabloAd�
--for triggerolay� (insert, update, delete)
--as
--T-Sql kodlar�...
--rollback

use MovieMarket
go

--M��teriler tablosundan ayn� anda birden fazla m��teri silinmesine izin vermeyen trigger kodlar�n� yaz�n�z.

create trigger Tg_CokluSilme
on Musteriler
for delete
as
if(select count(*) from deleted) > 1
	begin
		print 'Ayn� anda birden fazla m��teri silemezsiniz!'
		rollback
		return
	end
go

select * from Musteriler where Id>=12 
delete from Musteriler where Id>=12  --�ncelikle 12 ve 13 id'li m��teriler siliniyor. Ard�ndan trigger devreye giriyor ve birden fazla m��teri silindi�i i�in i�lemler rollback ile geri al�n�yor.

delete from Musteriler where Id>12  --Tek bir m��teri kayd� silindi�i i�in trigger devreye girdi ancak �art sa�lanmad���ndan rollback �al��mad�.

alter trigger Tg_CokluSilme
on Musteriler
for delete
as
if(select count(*) from deleted) > 0
	begin
		--print 'Yetkiniz yok, m��teri silemezsiniz!'
		raiserror('Yetkiniz yok, m��teri silemezsiniz!', 16, 1) --50000'li kullan�c� tan�ml� hata kodlar� f�rlat�l�yor. 
		rollback
		return
	end
go

delete from Musteriler where Id=12

alter table Musteriler
disable trigger tg_CokluSilme  --Trigger devre d��� kal�r, silme i�lemleri kontrol edilmez.

alter table Musteriler
enable trigger tg_CokluSilme  --Trigger yeniden devreye al�n�r, silme i�lemleri kontrol edilmeye ba�lan�r.

alter table Filmler
add Miktar int not null default 20

select * from Filmler

--Film sat��� ger�ekle�ti�inde filmin stok miktar�n� sat�� adedi kadar eksilten trigger kodlar�n� yaz�n�z.
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

--�nceden yap�lan 29 nolu sat��ta sat�� adedi yanl��l�kla 5 girilmi�, 3 olarak d�zeltilmesi isteniyor. Bu durumda sat�lan filmin stok miktar�n� d�zenleyen trigger kodlar�n� yaz�n�z.

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

--Sat�� sonras� sat�lan filmin stok miktar� 0 yada alt�na d��erse filmin stokta kalmad���n� yada sat���n�n devam edemeyece�ini (Varmi=0) tan�mlayan trigger kodlar�n� yaz�n�z.

--Instead Of Triggers 
--Bu trigger'lar k�s�tlay�c�lar (constraints) gibi �al���r, yani belirtilen i�lem yerine trigger'daki kodlar �al��m�� olur.
--Yine de inserted ve deleted dosyalar� olu�turulur.

Alter table Musteriler
Add Silindi bit default 0 not null

create trigger Tg_MusteriSilme
on Musteriler
instead of delete
as
update Musteriler set Silindi=1  from Musteriler inner join deleted on Musteriler.Id = deleted.Id
go

delete from Musteriler where Id=1