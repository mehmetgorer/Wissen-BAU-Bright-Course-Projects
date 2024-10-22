--VIEW Sorgularý
--Sýk sýk ihtiyaç duyabileceðimiz sql sorgularýný kaydettiðimiz sanal sorgu dosyalarýdýr. Verileri çektiði gerçek dosyalara (Filmler, FilmTurleri, FilmSatis gibi) temel (base) dosyalar adý verilir.
--Kullanýlma nedenleri:
--Normalizasyon nedeniyle oluþan çok sayýda dosyadan çekilen kompleks (çok sayýda join bulunan) sorgularý tekrar tekrar yazmamak,
--Sorgulara hesaplanmýþ kolonlarý rahatlýkla ve kalýcý olarak ekleyebilmek,
--Yetkilerde kolaylýkla sýnýrlandýrma yapabilmek (yetkisi olmayanlarýn gerçek dosyalardaki tüm kolonlara eriþimlerini sýnýrlamak),
--Bazý sorgularda ülke, bölge bazlý ölçeklendirmeler, formüller kullanmak.

select * from vw_SatislarMusteriler

Exec sp_helptext vw_SatislarMusteriler  --View dosyasýnýn kodlarýný görüntüler.

Alter VIEW dbo.vw_SatislarMusteriler  
AS  
SELECT dbo.FilmSatis.Tarih, dbo.Musteriler.Adi, dbo.Musteriler.Soyadi, dbo.FilmSatis.Adet, dbo.FilmSatis.BirimFiyat, dbo.FilmSatis.Adet * dbo.FilmSatis.BirimFiyat AS Tutar  
FROM dbo.FilmSatis INNER JOIN  
                         dbo.Musteriler ON dbo.FilmSatis.MusteriId = dbo.Musteriler.Id  
WHERE        (dbo.FilmSatis.Adet > 1) AND (dbo.FilmSatis.Adet <= 5)  

sp_depends vw_SatislarMusteriler  --view dosyasýnýn baðlý olduðu tablo ve kolon adlarýný listeler.

create view vw_DetayliSatis
as
select top (100) percent fs.Id, FilmAdi, Adi + ' ' + Soyadi as Musteri, Adet, BirimFiyat, Adet*BirimFiyat as ToplamTutar from FilmSatis as fs inner join Filmler as f on f.Id=fs.FilmId inner join Musteriler as m on m.Id=fs.MusteriId order by ToplamTutar desc

select * from vw_DetayliSatis where ToplamTutar>=200

--View dosyalarýný raporlamada çok kullanýyoruz, ancak insert, update, delete iþlemlerinde kullanmamalýyýz. Zaten çok sayýda tablo etkileneceðinden çoðunlukla hata mesajý alýrýz.

select * from sys.views  --mevcut view dosyalarýný listeler.

--with encryption kullanýlarak view dosyasýnýn içeriðinin görüntülenmesi engellenir.
Alter VIEW dbo.vw_SatislarMusteriler 
with encryption
AS  
SELECT dbo.FilmSatis.Tarih, dbo.Musteriler.Adi, dbo.Musteriler.Soyadi, dbo.FilmSatis.Adet, dbo.FilmSatis.BirimFiyat, dbo.FilmSatis.Adet * dbo.FilmSatis.BirimFiyat AS Tutar  
FROM dbo.FilmSatis INNER JOIN  
                         dbo.Musteriler ON dbo.FilmSatis.MusteriId = dbo.Musteriler.Id  
WHERE        (dbo.FilmSatis.Adet > 1) AND (dbo.FilmSatis.Adet <= 5) 


select * from vw_SatislarMusteriler

sp_helptext vw_SatislarMusteriler

--with encryption olmadan view dosyasý yeniden kayýt edilirse (Alter) içeriði tekrar görüntülenebilecektir.
Alter VIEW dbo.vw_SatislarMusteriler 
AS  
SELECT dbo.FilmSatis.Tarih, dbo.Musteriler.Adi, dbo.Musteriler.Soyadi, dbo.FilmSatis.Adet, dbo.FilmSatis.BirimFiyat, dbo.FilmSatis.Adet * dbo.FilmSatis.BirimFiyat AS Tutar  
FROM dbo.FilmSatis INNER JOIN  
                         dbo.Musteriler ON dbo.FilmSatis.MusteriId = dbo.Musteriler.Id  
WHERE        (dbo.FilmSatis.Adet > 1) AND (dbo.FilmSatis.Adet <= 5) 