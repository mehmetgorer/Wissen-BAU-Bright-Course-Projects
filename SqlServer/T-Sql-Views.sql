--VIEW Sorgular�
--S�k s�k ihtiya� duyabilece�imiz sql sorgular�n� kaydetti�imiz sanal sorgu dosyalar�d�r. Verileri �ekti�i ger�ek dosyalara (Filmler, FilmTurleri, FilmSatis gibi) temel (base) dosyalar ad� verilir.
--Kullan�lma nedenleri:
--Normalizasyon nedeniyle olu�an �ok say�da dosyadan �ekilen kompleks (�ok say�da join bulunan) sorgular� tekrar tekrar yazmamak,
--Sorgulara hesaplanm�� kolonlar� rahatl�kla ve kal�c� olarak ekleyebilmek,
--Yetkilerde kolayl�kla s�n�rland�rma yapabilmek (yetkisi olmayanlar�n ger�ek dosyalardaki t�m kolonlara eri�imlerini s�n�rlamak),
--Baz� sorgularda �lke, b�lge bazl� �l�eklendirmeler, form�ller kullanmak.

select * from vw_SatislarMusteriler

Exec sp_helptext vw_SatislarMusteriler  --View dosyas�n�n kodlar�n� g�r�nt�ler.

Alter VIEW dbo.vw_SatislarMusteriler  
AS  
SELECT dbo.FilmSatis.Tarih, dbo.Musteriler.Adi, dbo.Musteriler.Soyadi, dbo.FilmSatis.Adet, dbo.FilmSatis.BirimFiyat, dbo.FilmSatis.Adet * dbo.FilmSatis.BirimFiyat AS Tutar  
FROM dbo.FilmSatis INNER JOIN  
                         dbo.Musteriler ON dbo.FilmSatis.MusteriId = dbo.Musteriler.Id  
WHERE        (dbo.FilmSatis.Adet > 1) AND (dbo.FilmSatis.Adet <= 5)  

sp_depends vw_SatislarMusteriler  --view dosyas�n�n ba�l� oldu�u tablo ve kolon adlar�n� listeler.

create view vw_DetayliSatis
as
select top (100) percent fs.Id, FilmAdi, Adi + ' ' + Soyadi as Musteri, Adet, BirimFiyat, Adet*BirimFiyat as ToplamTutar from FilmSatis as fs inner join Filmler as f on f.Id=fs.FilmId inner join Musteriler as m on m.Id=fs.MusteriId order by ToplamTutar desc

select * from vw_DetayliSatis where ToplamTutar>=200

--View dosyalar�n� raporlamada �ok kullan�yoruz, ancak insert, update, delete i�lemlerinde kullanmamal�y�z. Zaten �ok say�da tablo etkilenece�inden �o�unlukla hata mesaj� al�r�z.

select * from sys.views  --mevcut view dosyalar�n� listeler.

--with encryption kullan�larak view dosyas�n�n i�eri�inin g�r�nt�lenmesi engellenir.
Alter VIEW dbo.vw_SatislarMusteriler 
with encryption
AS  
SELECT dbo.FilmSatis.Tarih, dbo.Musteriler.Adi, dbo.Musteriler.Soyadi, dbo.FilmSatis.Adet, dbo.FilmSatis.BirimFiyat, dbo.FilmSatis.Adet * dbo.FilmSatis.BirimFiyat AS Tutar  
FROM dbo.FilmSatis INNER JOIN  
                         dbo.Musteriler ON dbo.FilmSatis.MusteriId = dbo.Musteriler.Id  
WHERE        (dbo.FilmSatis.Adet > 1) AND (dbo.FilmSatis.Adet <= 5) 


select * from vw_SatislarMusteriler

sp_helptext vw_SatislarMusteriler

--with encryption olmadan view dosyas� yeniden kay�t edilirse (Alter) i�eri�i tekrar g�r�nt�lenebilecektir.
Alter VIEW dbo.vw_SatislarMusteriler 
AS  
SELECT dbo.FilmSatis.Tarih, dbo.Musteriler.Adi, dbo.Musteriler.Soyadi, dbo.FilmSatis.Adet, dbo.FilmSatis.BirimFiyat, dbo.FilmSatis.Adet * dbo.FilmSatis.BirimFiyat AS Tutar  
FROM dbo.FilmSatis INNER JOIN  
                         dbo.Musteriler ON dbo.FilmSatis.MusteriId = dbo.Musteriler.Id  
WHERE        (dbo.FilmSatis.Adet > 1) AND (dbo.FilmSatis.Adet <= 5) 