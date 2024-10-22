--Veritaban� Yedekleme ve Geri Y�kleme

--Backup komutu ile veritaban�n� yedekliyor, Restore ile geri y�kl�yoruz.
--Her veritaban�na mutlaka ilk olarak, yada yedekleme periyodunun ba�lang�c� olarak Full Backup i�lemi uygulanmal�d�r.
--SSMS ekran�nda veritaban� sa� tu� Tasks / Backup ile veritaban� yedeklenir. Al�nan yedek standart yol (path) olarak C:\Program Files\Sql Server\Versiyon klas�r�\MSSQL\Backup klas�r� alt�nda .bak uzant�l� olarak olu�turulur.
--Veritaban� varsa; al�nan yede�i geri y�klemek i�in SSMS (Sql Server Management Studio) ekran�nda ilgili veritaban� �zerinde sa� tu� Tasks / Restore / Database ile ilgili .bak yedek dosyas� ve options ekran�ndan Override(Replace) se�ilerek, orjinalinin �zerine geri y�kleme i�lemi ger�ekle�tirilir.
--E�er veritaban� yoksa; Databases �zerinde Restore Databases se�ilerek (override se�ilmeden) geri y�kleme ger�ekle�tirilir.

--Generate Scripts
--Veritaban� ta��man�n di�er yolu Script dosyalar�n� olu�turup istedi�imiz yerde �al��t�rmakt�r.
--Bunun i�in veritaban� �zerinde sa� tu� Generate Scripts / Next / Advanced / Types of data to script se�ene�inde Schema and data se�erek hem veritaban� olu�turma komutlar� hem de data ekleme komutlar� script dosyas�na i�lenir. �stedi�imiz bilgisayarda bu dosyay� SSMS Query sayfas�nda a�arak �al��t�r�p (execute) ilgili veritaban� olu�turulur ve i�indeki datalar eklenir.

--Backup Devices ile Yedekleme
--�ncelikle SSMS ekran�nda Server Objects / Backup Devices alt�nda kendimize istedi�imiz bir s�r�c� �zerinde yedekleme i�in bir klas�r (device) tan�ml�yoruz.
--Veritaban�m�z� hangi bilgisayara kurmak istersek, o bilgisayarda ayn� yola sahip (C:\SqlYedek) bir klas�r (device) olu�turuyoruz. Yede�imizi buraya kopyal�yoruz ve normal Databases �zerinden Restore Database i�lemini ger�ekle�tiriyoruz.

--T-Sql �zerinden Yedek Alma
--Backup ekran�ndan �st taraftan Script se�erek yedekleme kodlar�n� elde edebiliriz.
BACKUP DATABASE [MovieMarket] TO  [SqlYedek] WITH NOFORMAT, NOINIT,  NAME = N'MovieMarket-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
GO
--Restore ekran�ndan �st taraftan Script se�erek geri y�kleme kodlar�n� elde edebiliriz.
USE [master]
RESTORE DATABASE [MovieMarket] FROM  [SqlYedek] WITH  FILE = 1,  NOUNLOAD,  STATS = 5
GO
--Bu kodlar� �al��t�rarak (execute-F5) backup ve restore i�lemlerini ger�ekle�tirebiliriz.




