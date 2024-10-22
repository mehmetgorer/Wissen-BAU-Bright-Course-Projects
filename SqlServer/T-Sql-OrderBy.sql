--order by, top, with ties, distinct

--order by kolonadý [asc] -> (ascending) Küçükten büyüðe yada A -> Z artan sýralama yapar.
--order by kolonadý desc -> (descending) Büyükten küçüðe yada Z -> A azalan sýralama yapar.

use MovieMarket
go
--Müþterileri alfabetik sýraya göre listeleyen sorgu.
select * from Musteriler order by Adi

--Satýþ bilgilerini satýþ adetlerine göre büyükten küçüðe doðru listeleyen sorgu.
select * from FilmSatis order by Adet desc

--Satýþ bilgilerini alýþveriþ tutarlarýna göre sýralayan sorgu.
select *, Adet*BirimFiyat as ToplamTutar from FilmSatis order by ToplamTutar

--Top n [Percent] -> sorgu sonucu oluþan listenin üstten n sayýda satýrýný listeler.
--Select top n ...

--En yüksek tutarda ödeme yapýlan satýþa ait bilgileri listeleyen sorgu.
select max(Adet*BirimFiyat) as MaxTutar from FilmSatis --max satýþ tutarý geliyor ancak yanýna istediðimiz kadar bilgi ekleyemiyoruz (group by kolonadi1, kolonadi2, ...)
select top 1 *, Adet*BirimFiyat as ToplamTutar from FilmSatis order by ToplamTutar desc

select top 1 FilmAdi, Adi + ' ' + Soyadi as Musteri, Adet, BirimFiyat, Adet*BirimFiyat as ToplamTutar from FilmSatis inner join Filmler on Filmler.Id=FilmSatis.FilmId inner join Musteriler on Musteriler.Id=FilmSatis.MusteriId order by ToplamTutar desc

--Bir kampanya yapmak istiyoruz. Kampanya gününde en yüksek alýþveriþi yapan 3 müþteriye ödül vadediyoruz. Bu müþterileri listeleyen sorguyu yazýnýz.

insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(3,2,6,120)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(1,1,5,140)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(2,3,8,82.5)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(4,9,6,110)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(5,1,4,150)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(1,9,5,132)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(3,2,6,110)

select top 3 Convert(nvarchar(20), Tarih, 104) as KampanyaTarihi, Adi + ' ' + Soyadi as Müþteri, Telefon, Adet, BirimFiyat, Adet*BirimFiyat as ToplamHarcama from FilmSatis inner join Musteriler on Musteriler.Id=FilmSatis.MusteriId where Convert(Date, Tarih, 104)=Convert(Date, getdate(), 104) order by ToplamHarcama desc

--3. en yüksek alýþveriþ tutarýný (660) gerçekleþtiren 2 tane daha (toplam 6) alýþveriþ olmasýna raðmen listede görünmüyorlar.
--top n with ties kullandýðýmýzda, n sayýda kayýt listelendikten sonra kriter olarak belirtilen kolonda kýrýlma oluncaya kadar listelemeye devam ediyor.

select top 3 with ties Convert(nvarchar(20), Tarih, 104) as KampanyaTarihi, Adi + ' ' + Soyadi as Müþteri, Telefon, Adet, BirimFiyat, Adet*BirimFiyat as ToplamHarcama from FilmSatis inner join Musteriler on Musteriler.Id=FilmSatis.MusteriId where Convert(Date, Tarih, 104)=Convert(Date, getdate(), 104) order by ToplamHarcama desc

--Distinct : Liste içinde tekrar eden kayýtlardan sadece bir tanesini listeler.

insert into Musteriler(Adi, Soyadi, Telefon) values('Hasan', 'Demir', '2125256767')
insert into Musteriler(Adi, Soyadi, Telefon) values('Hatice', 'Altýn', '2163256968')
--Bugüne kadar yapýlan satýþlarda kaç farklý müþteri bizden alýþveriþ yapmýþtýr?
select count(*) müþterisayýsý from Musteriler --Bizde kaydý bulunan bazý müþteriler henüz alýþveriþ yapmadýklarýndan sayý fazla çýkýyor.
select distinct FilmId, MusteriId, Adet from FilmSatis --listedeki bilgiler her satýrda farklý
select distinct MusteriId from FilmSatis --Tekrar eden müþteri id'lerden sadece birini görüntüledi. Ancak sayýsý için count kullanmalýyýz.
select count(distinct MusteriId) as FarklýMüþteri from FilmSatis

--Marketimizde satýþý devam eden kaç farklý türde film vardýr?
select count(*) as sayýsý from FilmTurleri --Kaydý olan her türden elimizde film olmayabilir yada satýþý devam etmiyor olabilir.

select count(distinct TurId) as FarklýTür from Filmler where Varmi=1

