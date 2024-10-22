--Transact Structured Query Language (T-Sql)
--SQL -> Standart sorgulama dili.
--System Databases -> master, model, msdb (with Agent Service), tempdb
--Databases (User Defined) -> Bizim tanýmlayacaðýmýz tüm veritabanlarý Databases baþlýðý altýnda listelenir.
--Normalleþtirme; bütün verilerin tek büyük bir dosyada deðil, ilgili verilerin ilgili tablolarda tutulmasý, bu tablolarýn birbirleriyle iliþkilendirilerek veri bütünlüðünün saðlanmasý, gereksiz veri tekrarlarýnýn önlenmesi tekniðine normalleþtirme diyoruz.
--MS-Sql Server (Relational Database Management System -RDMS-)
--Sql Server, Ýliþkisel bir veritabaný yönetim sistemidir.

--Veri Bütünlüðü (Data Integrity)
--Tanýmlamalý Veri Bütünlüðü; Constraints (Kýsýtlayýcýlar), Rules, Defaults
--Programsal Veri Bütünlüðü; Stored Procedures, Triggers, (UDF)Functions gibi.
--Primary Key Constraint (Birincil Anahtar) : Tabloda sadece 1 adet tanýmalanabilir, Null olamaz, arka planda Unique (Clustered) index oluþturarak kaydýn tekilliðini saðlar.
--Unique Key Constraint : Birden fazla tanýmlanabilir, Null olabilir. Ancak ayný deðerde 2 kayda izin vermez (unique). Örn: TCKNo, Vergi No, SicilNo
--Check Constraints : Çeþitli alanlarda küçük veri kontrolleri, kurallar tanýmlayabiliriz (Yas >= 18, LEN(TCKNo)=11 gibi). Avantajlarý, transaction iþleminden önce devreye girerler, bu nedenle performans kaybý olmaz.
--Foreign Key Constraints (Yabancý Anahtar) : Bir tablodaki bazý kolonlarýn, diðer iliþkili tablodaki kolonlardan çaðýrýlmasýný saðlar.
--Primary Key, satýr (kayýt) üzerinde tekilliði zorlayarak veri bütünlüðünü korur.
--Kolon üzerinde veri bütünlüðünü, veri türlerini tanýmayarak ve null alanlara karar vererek saðlarýz.
--Referanssal Veri Bütünlüðü, normalleþtirme sonucu tablolarý birincil anahtar ve dýþ (foreign) anahtar üzerinden iliþkilendirerek veri tutarlýlýðýna zorluyoruz.
--New Database
--1 adet Primary Data File (.mdf), 1 adet de Transaction Log File (.ldf) oluþur. Bunlar Primary Filegroup içinde oluþurlar ve veritabanýnýn baþlangýç adresi de bu filegroup olur.
--AutoGrowth özelliði aktifleþtirilerek veri tabaný dolduðunda istenilen miktarlarda otomatik olarak büyütülmesi saðlanabilir.
--AutoShrink özelliði true yapýlýrsa, zamanla veritabaný üzerinde oluþan boþluklar (özellikle silme nedeniyle) %25 seviyeye geldiðinde otomatik olarak kaldýrýlýr ve veritabaný baþtan düzenlenir.

--Data Types (Veri Türleri)
--varchar(20), varchar(max) -> içine her türlü string bilgi girilebilir. Girilen bilgi ayrýlan alandan daha az ise fazla olan kýsmý hafýzadan iade eder.
--nvarchar(40) -> Ayrýlan alanýn yarýsýna girilen bilgileri alýrken, diðer yarýsýnda ise utf-8 tablo karþýlýklarýný takip eder.
--char, text gibi  veri türlerinde baþtan 8000 karakterlik yer ayrýldýðýndan genellikle varchar tercih ediyoruz.
--tinyint (byte), hafýzada 1 byte yer iþgal eder ve 0-255 arasý deðerleri girebiliriz.
--smallint, int, bigint, hafýzada 2-4-8 byte yer kaplarlar ve tamsayý deðerleri girebiliriz.
--kesirli sayýlarda float 4 byte yer ayrýlýr. Decimal ve Numeric veri türleriyle çok büyük kesirli sayýlar için hafýzada yer ayýrabiliriz.
--bit (boolean-bool), true/false, 1/0
--money, parasal deðerlerin takibinde kullanýlýr, double veri türüne benzer.
--TabloAdý üzerinde sað tuþ Design, tablo tasarým ekranýna dönmemizi saðlar.
--Design ekranýnda sað tuþ Indexes/Keys seçeneðinden Unique Key ve Index dosyalarý tanýmlanabilir. 
--Sað tuþ Check Constraints seçeneðinden kolonlarla ilgili kýsýtlamalar tanýmlanabilir (Age>= 18)
--Kýsýtlamalar tanýmlanýrken ilgili tabloda önceden girilmiþ veriler varsa, bu kýsýtlamalarla tutarlý olmasý beklenir, aksi durumda Sql kýsýtlamalarý tablo üzerine kayýt etmeyecektir.
--DateTime türünden bir kolonda Default Constraint olarak getdate() vererek, bilgi girilmediðinde otomatik olarak sistem tarih ve saatinin atýlmasýný saðlarýz.
--Her iki tabloyu iliþkilendirirken Diagrams ekranýný kullanabiliriz, kural olarak iliþki (relation) ayný türden kolonlar arasýnda kurulmalýdýr. Best Practice, Bire Çok (OneToMany) iliþkiler 1.tablonun primary key kolonu ile diðer tablonun dýþ anahtarý arsýnda gerçekleþtirilir. Diðer tablonun dýþ anahtar için ayrýlan alaný artýk Sql Server tarafýndan Foreign Key olarak kabul edilir.




