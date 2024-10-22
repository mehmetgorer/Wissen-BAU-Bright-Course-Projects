--LIKE Sorgular�
--KolonAd� like 'A%' -> A ile ba�layan herhangi bir karakter yada karakter grubuyla devam eden bilgiler.
--KolonAd� like '%bul' -> Nas�l ba�larsa ba�las�n sonu bul ifadesiyle biten kay�tlar.
--KolonAd� like '%izmir%' -> Belirtilen kolonun i�inde �zmir ge�en kay�tlar.

select * from Musteriler

--�smi A ile ba�layan m��terileri listeleyen sorgu.
select * from Musteriler where Adi like 'A%'
--k�yde oturan m��terilen listesi.
select * from Musteriler where Adres like '%k�y%'
--Anadolu yakas�nda oturan m��terilerin listesi.
select * from Musteriler where Telefon like '216%'
--Soyad� ar ile biten m��terilerin listesi.
select * from Musteriler where Soyadi like '%ar'

--Soyad� ar ile biten ve Ad� A ile ba�layan m��terilerin listesi.
select * from Musteriler where Soyadi like '%ar' and Adi like 'A%'

--Bradd Pitt'in oynad��� filmlerin listesi.
select * from Filmler where Oyuncular like '%Pitt%'
--Dram t�r�nden veya Bradd Pitt'in oynad��� filmlerin listesi.
select * from Filmler where TurId=1 or Oyuncular like '%Pitt%'

--Bradd Pitt'in oynad��� sava� filmlerinin listesi.
select * from Filmler where TurId=5 and Oyuncular like '%Pitt%'

--�smi A ile N aras�ndaki harflerle ba�layan m��terilerin listesi.
select * from Musteriler where Adi like '[A-N]%'
--�smi A ile ba�lamayan (A d���ndaki harflerle ba�layan) m��terilerin listesi.
select * from Musteriler where Adi like '[^A]%'
--�smi toplam 4 harften olu�an m��terilerin listesi.
select * from Musteriler where Adi like '____'
select * from Musteriler where LEN(Adi)=4
--�smi A ile ba�layan ve toplam 3 harften olu�an m��terilerin listesi.
select * from Musteriler where Adi like 'A__'

--Soyad� K veya G ile ba�layan ayn� zamanda ar ile biten m��terilerin listesi.
select * from Musteriler where Soyadi like '[KG]%ar'