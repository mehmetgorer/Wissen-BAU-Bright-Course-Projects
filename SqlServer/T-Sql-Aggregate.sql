--Aggregate Fonksiyonlar�
--Count, Sum, Avg, Max, Min gibi...
--Geriye tek bir sonu� d�nd�r�r. 

--�u andaki mevcut m��teri say�m�z?
select * from Musteriler
select count(Id) from Musteriler
select count(Adres) from Musteriler --count, Null i�eren sat�rlar� saymayaca��ndan hataya d��memek i�in Null olamayacak kolonlar (Id, not null �zelli�i olanlar) se�ilmelidir.
select count(*) as say�s� from Musteriler
select Adi, count(*) as say�s� from Musteriler --Aggregate fonksiyonlar� tek sonu� d�nd�rd���nden hata verecektir. Ancak Group By kolonad� kullan�l�rsa, listeye ilgili kolon ad� da eklenebilir.
select * from FilmSatis
--Bu g�ne kadar sat�lan filmlerin toplam adetini g�steren sorgu.
select sum(Adet) as ToplamAdet from FilmSatis

--Bu g�ne kadar yap�lan sat��larda �denen en y�ksek film birim fiyat�n� g�steren sorgu.
select max(BirimFiyat) as maxFiyat from FilmSatis
--Bu g�ne kadar yap�lan sat��lar� sat�� tutar�yla birlikte listeleyen sorgu.
select *, Adet*BirimFiyat as Tutar from FilmSatis
--Bu g�ne kadar sat��lardan elde etti�imiz toplam has�lat� g�steren sorgu.
select sum(Adet*BirimFiyat) as Toplam from FilmSatis

--M��terilerin yapt��� toplam al��veri� tutarlar�n� m��teri id'leriyle birlikte g�steren sorgu.
select MusteriId, sum(Adet*BirimFiyat) as Toplam from FilmSatis group by MusteriId

--Bu g�ne kadar hangi filmden toplam ka�ar adet sat�ld���n� g�steren sorgu.
select FilmId, sum(Adet) as ToplamAdet from FilmSatis group by FilmId

---------
--Filmlere g�re toplam sat�� adetlerini film isimleriyle birlikte g�steren sorgu
use MovieMarket
go
select FilmAdi, sum(Adet) as ToplamAdet from FilmSatis fs inner join Filmler f on fs.FilmId = f.Id group by FilmAdi

--select * from TabloAd� where �art ifadesi group by kolonad� having �art ifadesi
--Sadece Toplam Sat�� Adeti 12 ile 18 aras�nda olanlar� listelesin.

select FilmAdi, sum(Adet) as ToplamAdet from FilmSatis fs inner join Filmler f on fs.FilmId = f.Id group by FilmAdi having sum(Adet) >= 12 and sum(Adet) <= 18

select FilmAdi, sum(Adet) as ToplamAdet from FilmSatis fs inner join Filmler f on fs.FilmId = f.Id group by FilmAdi having sum(Adet) between 12 and 18

--having ifadesi, gruplar olu�tuktan sonra filtreleme uygulamay� sa�lar.
--Yaz�l�� s�ras�ndan da anla��ld��� gibi e�er Where ifadesi varsa gruplamadan �nce �al���r, having gruplamadan sonra �al���r.

--IN ve NOT IN
Select * from Filmler where Id IN (2, 4)  --Id=2 or Id=4 gibi
Select * from Filmler where Id NOT IN (2, 4) --Id'si 2 veya 4 olmayanlar� listeler.

select FilmAdi from FilmSatis fs inner join Filmler f on fs.FilmId = f.Id group by FilmAdi having sum(Adet) between 12 and 18

--Toplam Sat�� adetleri 12 ile 18 aras�nda olan filmlerin detayl� bilgilerini listeleyen sorgu. 
--(SubQuery �rne�i)
select FilmAdi, Yonetmen, Oyuncular, Ozet, Miktar from Filmler where FilmAdi IN (select FilmAdi from FilmSatis fs inner join Filmler f on fs.FilmId = f.Id group by FilmAdi having sum(Adet) between 12 and 18)