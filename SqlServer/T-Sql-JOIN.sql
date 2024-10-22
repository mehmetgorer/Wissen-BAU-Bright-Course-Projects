--Ýliþkilendirme (JOIN) Ýþlemleri

--Birden fazla tabloyu ortak kolonlar (veri türleri ayný olan) üzerinden birbirine baðlar. Bu sayede iliþkilendirilen tablolarýn tüm kolonlarýný sorgularýmýzda kullanabiliriz.
--Inner Join (Join) : Ortak kolon bilgisini kullanarak diðer tablodan ilgili verileri çekmemizi saðlar.
--Left Outer Join (Left Join) : Ýliþkilendirilen tablolardan soldaki (1.tablo) tablonun tüm kayýtlarýný diðer tabloda karþýlýðý olsa da olmasa da listeler.
--Right Outer Join (Right Join) : Ýliþkilendirilen tablolardan saðdaki (2.tablo) tablonun tüm kayýtlarýný diðer tabloda karþýlýðý olsa da olmasa da listeler. 
--Outer join'lerde diðer tabloda karþýlýðý yoksa listede NULL olarak görüntülenir.
--Cross join : Birinci tablodaki her kayýt diðer tablodaki tüm kayýtlarla çapraz olarak eþleþtirilir.

--Tablo-1 inner join Tablo-2 on Tablo-1.ortakkolon = Tablo-2.ortakkolon
select * from FilmSatis
--Marketimizde bulunan film bilgilerini tür isimleriyle birlikte listeleyen sorgu.
select Filmler.Id, FilmAdi, TurAdi, Yonetmen, Oyuncular from Filmler inner join FilmTurleri on Filmler.TurId = FilmTurleri.Id
--Her iki tabloda da ayný isimle kolonlar tanýmlanmýþsa, listeleme sýrasýnda ambiguous column hatasý alýnýr. Çözüm olarak TabloAdi.KolonAdi þeklinde tanýmlamamýz gerekir (Filmler.Id gibi).

--Dram türündeki filmleri listeleyen sorgu.
select Filmler.Id, FilmAdi, TurAdi, Yonetmen, Oyuncular from Filmler inner join FilmTurleri on Filmler.TurId = FilmTurleri.Id where TurAdi='Dram'

--Film satýþ bilgilerini film adlarýyla birlikte listeleyen sorgu.
select Tarih, FilmAdi, Adet, BirimFiyat, Adet*BirimFiyat as Tutar from FilmSatis as fs inner join Filmler as f on fs.FilmId = f.Id

--Satýþ bilgilerini müþteri ad ve soyadýyla birlikte listeleyen sorgu.
select Adi, Soyadi, Adet, BirimFiyat, Adet*BirimFiyat as Tutar from FilmSatis as fs inner join Musteriler as m on fs.MusteriId = m.Id

select Adi + ' ' + Soyadi as Musteri, Adet, BirimFiyat, Adet*BirimFiyat as Tutar from FilmSatis as fs inner join Musteriler as m on fs.MusteriId = m.Id

--Herbir müþterinin yaptýðý toplam alýþveriþ tutarlarýný müþteri adý ve soyadýyla birlikte gösteren sorguyu yazýnýz.
select Adi + ' ' + Soyadi as Müþteri, sum(Adet*BirimFiyat) as ToplamAlýþveriþ from FilmSatis inner join Musteriler on Musteriler.Id = FilmSatis.MusteriId group by Adi + ' ' + Soyadi

--Filmlerin toplam satýþ adetlerini film adlarýyla birlikte listeleyen sorguyu yazýnýz.
select FilmAdi, sum(Adet) as ToplamAdet from FilmSatis as fs inner join Filmler as f on fs.FilmId = f.Id group by FilmAdi

--Herbir filme ait ortalama birim fiyat, alýþveriþ sayýsý bilgilerini film isimleriyle birlikte gösteren sorguyu yazýnýz.
select FilmAdi, avg(BirimFiyat) as OrtalamaFiyat, count(*) as AlýþveriþSayýsý from FilmSatis as fs inner join Filmler as f on fs.FilmId = f.Id group by FilmAdi

--Bu güne kadar yapýlan satýþlarý film adý ve müþteri ad-soyadýyla birlikte listeleyen sorguyu yazýnýz.
select FilmAdi, Adi + ' ' + Soyadi as Müþteri, Adet, BirimFiyat, Adet*BirimFiyat as Tutar from FilmSatis as fs inner join Musteriler as m on fs.MusteriId = m.Id inner join Filmler as f on fs.FilmId = f.Id 

--Film Türlerine göre; bugüne kadar yapýlan toplam satýþ adetlerini ve alýþveriþ tutarlarýný gösteren sorgu.
select TurAdi, sum(Adet*BirimFiyat) as ToplamTutar, sum(Adet) as ToplamAdet from FilmTurleri inner join Filmler on Filmturleri.Id = Filmler.TurId inner join FilmSatis on FilmSatis.FilmId = Filmler.Id group by TurAdi 

--Left Outer Join (Left Join) : Ýliþkilendirilen tablolardan soldaki (1.tablo) tablonun tüm kayýtlarýný diðer tabloda karþýlýðý olsa da olmasa da listeler.
select * from FilmTurleri left join Filmler on Filmler.TurId = FilmTurleri.Id
--Normal join iþlemlerinde görüntülenmeyen tür bilgileri left outer join kullanýldýðýnda FilmTurleri 1.tablo (soldaki tablo) olduðundan tümü listeleniyor, diðer tabloda karþýlýðý olmayan kolonlarda NULL görüntüleniyor.

--Right Outer Join (Right Join) : Ýliþkilendirilen tablolardan saðdaki (1.tablo) tablonun tüm kayýtlarýný diðer tabloda karþýlýðý olsa da olmasa da listeler.
select * from Filmler right join FilmTurleri on Filmler.TurId = FilmTurleri.Id
--Normal join iþlemlerinde görüntülenmeyen tür bilgileri left outer join kullanýldýðýnda FilmTurleri 1.tablo (soldaki tablo) olduðundan tümü listeleniyor, diðer tabloda karþýlýðý olmayan kolonlarda NULL görüntüleniyor.

--Cross join : Birinci tablodaki her kayýt diðer tablodaki tüm kayýtlarla çapraz olarak eþleþtirilir.
select FilmAdi, TurAdi from Filmler cross join FilmTurleri