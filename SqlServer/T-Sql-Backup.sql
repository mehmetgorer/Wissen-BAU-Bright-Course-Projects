--Veritabaný Yedekleme ve Geri Yükleme

--Backup komutu ile veritabanýný yedekliyor, Restore ile geri yüklüyoruz.
--Her veritabanýna mutlaka ilk olarak, yada yedekleme periyodunun baþlangýcý olarak Full Backup iþlemi uygulanmalýdýr.
--SSMS ekranýnda veritabaný sað tuþ Tasks / Backup ile veritabaný yedeklenir. Alýnan yedek standart yol (path) olarak C:\Program Files\Sql Server\Versiyon klasörü\MSSQL\Backup klasörü altýnda .bak uzantýlý olarak oluþturulur.
--Veritabaný varsa; alýnan yedeði geri yüklemek için SSMS (Sql Server Management Studio) ekranýnda ilgili veritabaný üzerinde sað tuþ Tasks / Restore / Database ile ilgili .bak yedek dosyasý ve options ekranýndan Override(Replace) seçilerek, orjinalinin üzerine geri yükleme iþlemi gerçekleþtirilir.
--Eðer veritabaný yoksa; Databases üzerinde Restore Databases seçilerek (override seçilmeden) geri yükleme gerçekleþtirilir.

--Generate Scripts
--Veritabaný taþýmanýn diðer yolu Script dosyalarýný oluþturup istediðimiz yerde çalýþtýrmaktýr.
--Bunun için veritabaný üzerinde sað tuþ Generate Scripts / Next / Advanced / Types of data to script seçeneðinde Schema and data seçerek hem veritabaný oluþturma komutlarý hem de data ekleme komutlarý script dosyasýna iþlenir. Ýstediðimiz bilgisayarda bu dosyayý SSMS Query sayfasýnda açarak çalýþtýrýp (execute) ilgili veritabaný oluþturulur ve içindeki datalar eklenir.

--Backup Devices ile Yedekleme
--Öncelikle SSMS ekranýnda Server Objects / Backup Devices altýnda kendimize istediðimiz bir sürücü üzerinde yedekleme için bir klasör (device) tanýmlýyoruz.
--Veritabanýmýzý hangi bilgisayara kurmak istersek, o bilgisayarda ayný yola sahip (C:\SqlYedek) bir klasör (device) oluþturuyoruz. Yedeðimizi buraya kopyalýyoruz ve normal Databases üzerinden Restore Database iþlemini gerçekleþtiriyoruz.

--T-Sql üzerinden Yedek Alma
--Backup ekranýndan üst taraftan Script seçerek yedekleme kodlarýný elde edebiliriz.
BACKUP DATABASE [MovieMarket] TO  [SqlYedek] WITH NOFORMAT, NOINIT,  NAME = N'MovieMarket-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
GO
--Restore ekranýndan üst taraftan Script seçerek geri yükleme kodlarýný elde edebiliriz.
USE [master]
RESTORE DATABASE [MovieMarket] FROM  [SqlYedek] WITH  FILE = 1,  NOUNLOAD,  STATS = 5
GO
--Bu kodlarý çalýþtýrarak (execute-F5) backup ve restore iþlemlerini gerçekleþtirebiliriz.




