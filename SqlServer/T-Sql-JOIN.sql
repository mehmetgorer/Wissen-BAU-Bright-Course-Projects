--�li�kilendirme (JOIN) ��lemleri

--Birden fazla tabloyu ortak kolonlar (veri t�rleri ayn� olan) �zerinden birbirine ba�lar. Bu sayede ili�kilendirilen tablolar�n t�m kolonlar�n� sorgular�m�zda kullanabiliriz.
--Inner Join (Join) : Ortak kolon bilgisini kullanarak di�er tablodan ilgili verileri �ekmemizi sa�lar.
--Left Outer Join (Left Join) : �li�kilendirilen tablolardan soldaki (1.tablo) tablonun t�m kay�tlar�n� di�er tabloda kar��l��� olsa da olmasa da listeler.
--Right Outer Join (Right Join) : �li�kilendirilen tablolardan sa�daki (2.tablo) tablonun t�m kay�tlar�n� di�er tabloda kar��l��� olsa da olmasa da listeler. 
--Outer join'lerde di�er tabloda kar��l��� yoksa listede NULL olarak g�r�nt�lenir.
--Cross join : Birinci tablodaki her kay�t di�er tablodaki t�m kay�tlarla �apraz olarak e�le�tirilir.

--Tablo-1 inner join Tablo-2 on Tablo-1.ortakkolon = Tablo-2.ortakkolon
select * from FilmSatis
--Marketimizde bulunan film bilgilerini t�r isimleriyle birlikte listeleyen sorgu.
select Filmler.Id, FilmAdi, TurAdi, Yonetmen, Oyuncular from Filmler inner join FilmTurleri on Filmler.TurId = FilmTurleri.Id
--Her iki tabloda da ayn� isimle kolonlar tan�mlanm��sa, listeleme s�ras�nda ambiguous column hatas� al�n�r. ��z�m olarak TabloAdi.KolonAdi �eklinde tan�mlamam�z gerekir (Filmler.Id gibi).

--Dram t�r�ndeki filmleri listeleyen sorgu.
select Filmler.Id, FilmAdi, TurAdi, Yonetmen, Oyuncular from Filmler inner join FilmTurleri on Filmler.TurId = FilmTurleri.Id where TurAdi='Dram'

--Film sat�� bilgilerini film adlar�yla birlikte listeleyen sorgu.
select Tarih, FilmAdi, Adet, BirimFiyat, Adet*BirimFiyat as Tutar from FilmSatis as fs inner join Filmler as f on fs.FilmId = f.Id

--Sat�� bilgilerini m��teri ad ve soyad�yla birlikte listeleyen sorgu.
select Adi, Soyadi, Adet, BirimFiyat, Adet*BirimFiyat as Tutar from FilmSatis as fs inner join Musteriler as m on fs.MusteriId = m.Id

select Adi + ' ' + Soyadi as Musteri, Adet, BirimFiyat, Adet*BirimFiyat as Tutar from FilmSatis as fs inner join Musteriler as m on fs.MusteriId = m.Id

--Herbir m��terinin yapt��� toplam al��veri� tutarlar�n� m��teri ad� ve soyad�yla birlikte g�steren sorguyu yaz�n�z.
select Adi + ' ' + Soyadi as M��teri, sum(Adet*BirimFiyat) as ToplamAl��veri� from FilmSatis inner join Musteriler on Musteriler.Id = FilmSatis.MusteriId group by Adi + ' ' + Soyadi

--Filmlerin toplam sat�� adetlerini film adlar�yla birlikte listeleyen sorguyu yaz�n�z.
select FilmAdi, sum(Adet) as ToplamAdet from FilmSatis as fs inner join Filmler as f on fs.FilmId = f.Id group by FilmAdi

--Herbir filme ait ortalama birim fiyat, al��veri� say�s� bilgilerini film isimleriyle birlikte g�steren sorguyu yaz�n�z.
select FilmAdi, avg(BirimFiyat) as OrtalamaFiyat, count(*) as Al��veri�Say�s� from FilmSatis as fs inner join Filmler as f on fs.FilmId = f.Id group by FilmAdi

--Bu g�ne kadar yap�lan sat��lar� film ad� ve m��teri ad-soyad�yla birlikte listeleyen sorguyu yaz�n�z.
select FilmAdi, Adi + ' ' + Soyadi as M��teri, Adet, BirimFiyat, Adet*BirimFiyat as Tutar from FilmSatis as fs inner join Musteriler as m on fs.MusteriId = m.Id inner join Filmler as f on fs.FilmId = f.Id 

--Film T�rlerine g�re; bug�ne kadar yap�lan toplam sat�� adetlerini ve al��veri� tutarlar�n� g�steren sorgu.
select TurAdi, sum(Adet*BirimFiyat) as ToplamTutar, sum(Adet) as ToplamAdet from FilmTurleri inner join Filmler on Filmturleri.Id = Filmler.TurId inner join FilmSatis on FilmSatis.FilmId = Filmler.Id group by TurAdi 

--Left Outer Join (Left Join) : �li�kilendirilen tablolardan soldaki (1.tablo) tablonun t�m kay�tlar�n� di�er tabloda kar��l��� olsa da olmasa da listeler.
select * from FilmTurleri left join Filmler on Filmler.TurId = FilmTurleri.Id
--Normal join i�lemlerinde g�r�nt�lenmeyen t�r bilgileri left outer join kullan�ld���nda FilmTurleri 1.tablo (soldaki tablo) oldu�undan t�m� listeleniyor, di�er tabloda kar��l��� olmayan kolonlarda NULL g�r�nt�leniyor.

--Right Outer Join (Right Join) : �li�kilendirilen tablolardan sa�daki (1.tablo) tablonun t�m kay�tlar�n� di�er tabloda kar��l��� olsa da olmasa da listeler.
select * from Filmler right join FilmTurleri on Filmler.TurId = FilmTurleri.Id
--Normal join i�lemlerinde g�r�nt�lenmeyen t�r bilgileri left outer join kullan�ld���nda FilmTurleri 1.tablo (soldaki tablo) oldu�undan t�m� listeleniyor, di�er tabloda kar��l��� olmayan kolonlarda NULL g�r�nt�leniyor.

--Cross join : Birinci tablodaki her kay�t di�er tablodaki t�m kay�tlarla �apraz olarak e�le�tirilir.
select FilmAdi, TurAdi from Filmler cross join FilmTurleri