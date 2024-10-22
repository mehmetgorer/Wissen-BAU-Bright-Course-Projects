--Aggregate Fonksiyonları
--Count, Sum, Avg, Max, Min gibi...
--Geriye tek bir sonuç döndürür. 

--Şu andaki mevcut müşteri sayımız?
select * from Musteriler
select count(Id) from Musteriler
select count(Adres) from Musteriler --count, Null içeren satırları saymayacağından hataya düşmemek için Null olamayacak kolonlar (Id, not null özelliği olanlar) seçilmelidir.
select count(*) as sayısı from Musteriler
select Adi, count(*) as sayısı from Musteriler --Aggregate fonksiyonları tek sonuç döndürdüğünden hata verecektir. Ancak Group By kolonadı kullanılırsa, listeye ilgili kolon adı da eklenebilir.
select * from FilmSatis
--Bu güne kadar satılan filmlerin toplam adetini gösteren sorgu.
select sum(Adet) as ToplamAdet from FilmSatis

--Bu güne kadar yapılan satışlarda ödenen en yüksek film birim fiyatını gösteren sorgu.
select max(BirimFiyat) as maxFiyat from FilmSatis
--Bu güne kadar yapılan satışları satış tutarıyla birlikte listeleyen sorgu.
select *, Adet*BirimFiyat as Tutar from FilmSatis
--Bu güne kadar satışlardan elde ettiğimiz toplam hasılatı gösteren sorgu.
select sum(Adet*BirimFiyat) as Toplam from FilmSatis

--Müşterilerin yaptığı toplam alışveriş tutarlarını müşteri id'leriyle birlikte gösteren sorgu.
select MusteriId, sum(Adet*BirimFiyat) as Toplam from FilmSatis group by MusteriId

--Bu güne kadar hangi filmden toplam kaçar adet satıldığını gösteren sorgu.
select FilmId, sum(Adet) as ToplamAdet from FilmSatis group by FilmId

---------
--Filmlere göre toplam satış adetlerini film isimleriyle birlikte gösteren sorgu
use MovieMarket
go
select FilmAdi, sum(Adet) as ToplamAdet from FilmSatis fs inner join Filmler f on fs.FilmId = f.Id group by FilmAdi

--select * from TabloAdı where Şart ifadesi group by kolonadı having şart ifadesi
--Sadece Toplam Satış Adeti 12 ile 18 arasında olanları listelesin.

select FilmAdi, sum(Adet) as ToplamAdet from FilmSatis fs inner join Filmler f on fs.FilmId = f.Id group by FilmAdi having sum(Adet) >= 12 and sum(Adet) <= 18

select FilmAdi, sum(Adet) as ToplamAdet from FilmSatis fs inner join Filmler f on fs.FilmId = f.Id group by FilmAdi having sum(Adet) between 12 and 18

--having ifadesi, gruplar oluştuktan sonra filtreleme uygulamayı sağlar.
--Yazılış sırasından da anlaşıldığı gibi eğer Where ifadesi varsa gruplamadan önce çalışır, having gruplamadan sonra çalışır.

--IN ve NOT IN
Select * from Filmler where Id IN (2, 4)  --Id=2 or Id=4 gibi
Select * from Filmler where Id NOT IN (2, 4) --Id'si 2 veya 4 olmayanları listeler.

select FilmAdi from FilmSatis fs inner join Filmler f on fs.FilmId = f.Id group by FilmAdi having sum(Adet) between 12 and 18

--Toplam Satış adetleri 12 ile 18 arasında olan filmlerin detaylı bilgilerini listeleyen sorgu. 
--(SubQuery örneği)
select FilmAdi, Yonetmen, Oyuncular, Ozet, Miktar from Filmler where FilmAdi IN (select FilmAdi from FilmSatis fs inner join Filmler f on fs.FilmId = f.Id group by FilmAdi having sum(Adet) between 12 and 18)