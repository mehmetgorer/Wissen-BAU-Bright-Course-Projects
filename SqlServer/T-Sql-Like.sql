--LIKE Sorgularý
--KolonAdý like 'A%' -> A ile baþlayan herhangi bir karakter yada karakter grubuyla devam eden bilgiler.
--KolonAdý like '%bul' -> Nasýl baþlarsa baþlasýn sonu bul ifadesiyle biten kayýtlar.
--KolonAdý like '%izmir%' -> Belirtilen kolonun içinde Ýzmir geçen kayýtlar.

select * from Musteriler

--Ýsmi A ile baþlayan müþterileri listeleyen sorgu.
select * from Musteriler where Adi like 'A%'
--köyde oturan müþterilen listesi.
select * from Musteriler where Adres like '%köy%'
--Anadolu yakasýnda oturan müþterilerin listesi.
select * from Musteriler where Telefon like '216%'
--Soyadý ar ile biten müþterilerin listesi.
select * from Musteriler where Soyadi like '%ar'

--Soyadý ar ile biten ve Adý A ile baþlayan müþterilerin listesi.
select * from Musteriler where Soyadi like '%ar' and Adi like 'A%'

--Bradd Pitt'in oynadýðý filmlerin listesi.
select * from Filmler where Oyuncular like '%Pitt%'
--Dram türünden veya Bradd Pitt'in oynadýðý filmlerin listesi.
select * from Filmler where TurId=1 or Oyuncular like '%Pitt%'

--Bradd Pitt'in oynadýðý savaþ filmlerinin listesi.
select * from Filmler where TurId=5 and Oyuncular like '%Pitt%'

--Ýsmi A ile N arasýndaki harflerle baþlayan müþterilerin listesi.
select * from Musteriler where Adi like '[A-N]%'
--Ýsmi A ile baþlamayan (A dýþýndaki harflerle baþlayan) müþterilerin listesi.
select * from Musteriler where Adi like '[^A]%'
--Ýsmi toplam 4 harften oluþan müþterilerin listesi.
select * from Musteriler where Adi like '____'
select * from Musteriler where LEN(Adi)=4
--Ýsmi A ile baþlayan ve toplam 3 harften oluþan müþterilerin listesi.
select * from Musteriler where Adi like 'A__'

--Soyadý K veya G ile baþlayan ayný zamanda ar ile biten müþterilerin listesi.
select * from Musteriler where Soyadi like '[KG]%ar'