--order by, top, with ties, distinct

--order by kolonad� [asc] -> (ascending) K���kten b�y��e yada A -> Z artan s�ralama yapar.
--order by kolonad� desc -> (descending) B�y�kten k����e yada Z -> A azalan s�ralama yapar.

use MovieMarket
go
--M��terileri alfabetik s�raya g�re listeleyen sorgu.
select * from Musteriler order by Adi

--Sat�� bilgilerini sat�� adetlerine g�re b�y�kten k����e do�ru listeleyen sorgu.
select * from FilmSatis order by Adet desc

--Sat�� bilgilerini al��veri� tutarlar�na g�re s�ralayan sorgu.
select *, Adet*BirimFiyat as ToplamTutar from FilmSatis order by ToplamTutar

--Top n [Percent] -> sorgu sonucu olu�an listenin �stten n say�da sat�r�n� listeler.
--Select top n ...

--En y�ksek tutarda �deme yap�lan sat��a ait bilgileri listeleyen sorgu.
select max(Adet*BirimFiyat) as MaxTutar from FilmSatis --max sat�� tutar� geliyor ancak yan�na istedi�imiz kadar bilgi ekleyemiyoruz (group by kolonadi1, kolonadi2, ...)
select top 1 *, Adet*BirimFiyat as ToplamTutar from FilmSatis order by ToplamTutar desc

select top 1 FilmAdi, Adi + ' ' + Soyadi as Musteri, Adet, BirimFiyat, Adet*BirimFiyat as ToplamTutar from FilmSatis inner join Filmler on Filmler.Id=FilmSatis.FilmId inner join Musteriler on Musteriler.Id=FilmSatis.MusteriId order by ToplamTutar desc

--Bir kampanya yapmak istiyoruz. Kampanya g�n�nde en y�ksek al��veri�i yapan 3 m��teriye �d�l vadediyoruz. Bu m��terileri listeleyen sorguyu yaz�n�z.

insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(3,2,6,120)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(1,1,5,140)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(2,3,8,82.5)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(4,9,6,110)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(5,1,4,150)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(1,9,5,132)
insert into FilmSatis(FilmId, MusteriId, Adet, BirimFiyat) values(3,2,6,110)

select top 3 Convert(nvarchar(20), Tarih, 104) as KampanyaTarihi, Adi + ' ' + Soyadi as M��teri, Telefon, Adet, BirimFiyat, Adet*BirimFiyat as ToplamHarcama from FilmSatis inner join Musteriler on Musteriler.Id=FilmSatis.MusteriId where Convert(Date, Tarih, 104)=Convert(Date, getdate(), 104) order by ToplamHarcama desc

--3. en y�ksek al��veri� tutar�n� (660) ger�ekle�tiren 2 tane daha (toplam 6) al��veri� olmas�na ra�men listede g�r�nm�yorlar.
--top n with ties kulland���m�zda, n say�da kay�t listelendikten sonra kriter olarak belirtilen kolonda k�r�lma oluncaya kadar listelemeye devam ediyor.

select top 3 with ties Convert(nvarchar(20), Tarih, 104) as KampanyaTarihi, Adi + ' ' + Soyadi as M��teri, Telefon, Adet, BirimFiyat, Adet*BirimFiyat as ToplamHarcama from FilmSatis inner join Musteriler on Musteriler.Id=FilmSatis.MusteriId where Convert(Date, Tarih, 104)=Convert(Date, getdate(), 104) order by ToplamHarcama desc

--Distinct : Liste i�inde tekrar eden kay�tlardan sadece bir tanesini listeler.

insert into Musteriler(Adi, Soyadi, Telefon) values('Hasan', 'Demir', '2125256767')
insert into Musteriler(Adi, Soyadi, Telefon) values('Hatice', 'Alt�n', '2163256968')
--Bug�ne kadar yap�lan sat��larda ka� farkl� m��teri bizden al��veri� yapm��t�r?
select count(*) m��terisay�s� from Musteriler --Bizde kayd� bulunan baz� m��teriler hen�z al��veri� yapmad�klar�ndan say� fazla ��k�yor.
select distinct FilmId, MusteriId, Adet from FilmSatis --listedeki bilgiler her sat�rda farkl�
select distinct MusteriId from FilmSatis --Tekrar eden m��teri id'lerden sadece birini g�r�nt�ledi. Ancak say�s� i�in count kullanmal�y�z.
select count(distinct MusteriId) as Farkl�M��teri from FilmSatis

--Marketimizde sat��� devam eden ka� farkl� t�rde film vard�r?
select count(*) as say�s� from FilmTurleri --Kayd� olan her t�rden elimizde film olmayabilir yada sat��� devam etmiyor olabilir.

select count(distinct TurId) as Farkl�T�r from Filmler where Varmi=1

