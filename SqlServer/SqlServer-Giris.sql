--Transact Structured Query Language (T-Sql)
--SQL -> Standart sorgulama dili.
--System Databases -> master, model, msdb (with Agent Service), tempdb
--Databases (User Defined) -> Bizim tan�mlayaca��m�z t�m veritabanlar� Databases ba�l��� alt�nda listelenir.
--Normalle�tirme; b�t�n verilerin tek b�y�k bir dosyada de�il, ilgili verilerin ilgili tablolarda tutulmas�, bu tablolar�n birbirleriyle ili�kilendirilerek veri b�t�nl���n�n sa�lanmas�, gereksiz veri tekrarlar�n�n �nlenmesi tekni�ine normalle�tirme diyoruz.
--MS-Sql Server (Relational Database Management System -RDMS-)
--Sql Server, �li�kisel bir veritaban� y�netim sistemidir.

--Veri B�t�nl��� (Data Integrity)
--Tan�mlamal� Veri B�t�nl���; Constraints (K�s�tlay�c�lar), Rules, Defaults
--Programsal Veri B�t�nl���; Stored Procedures, Triggers, (UDF)Functions gibi.
--Primary Key Constraint (Birincil Anahtar) : Tabloda sadece 1 adet tan�malanabilir, Null olamaz, arka planda Unique (Clustered) index olu�turarak kayd�n tekilli�ini sa�lar.
--Unique Key Constraint : Birden fazla tan�mlanabilir, Null olabilir. Ancak ayn� de�erde 2 kayda izin vermez (unique). �rn: TCKNo, Vergi No, SicilNo
--Check Constraints : �e�itli alanlarda k���k veri kontrolleri, kurallar tan�mlayabiliriz (Yas >= 18, LEN(TCKNo)=11 gibi). Avantajlar�, transaction i�leminden �nce devreye girerler, bu nedenle performans kayb� olmaz.
--Foreign Key Constraints (Yabanc� Anahtar) : Bir tablodaki baz� kolonlar�n, di�er ili�kili tablodaki kolonlardan �a��r�lmas�n� sa�lar.
--Primary Key, sat�r (kay�t) �zerinde tekilli�i zorlayarak veri b�t�nl���n� korur.
--Kolon �zerinde veri b�t�nl���n�, veri t�rlerini tan�mayarak ve null alanlara karar vererek sa�lar�z.
--Referanssal Veri B�t�nl���, normalle�tirme sonucu tablolar� birincil anahtar ve d�� (foreign) anahtar �zerinden ili�kilendirerek veri tutarl�l���na zorluyoruz.
--New Database
--1 adet Primary Data File (.mdf), 1 adet de Transaction Log File (.ldf) olu�ur. Bunlar Primary Filegroup i�inde olu�urlar ve veritaban�n�n ba�lang�� adresi de bu filegroup olur.
--AutoGrowth �zelli�i aktifle�tirilerek veri taban� doldu�unda istenilen miktarlarda otomatik olarak b�y�t�lmesi sa�lanabilir.
--AutoShrink �zelli�i true yap�l�rsa, zamanla veritaban� �zerinde olu�an bo�luklar (�zellikle silme nedeniyle) %25 seviyeye geldi�inde otomatik olarak kald�r�l�r ve veritaban� ba�tan d�zenlenir.

--Data Types (Veri T�rleri)
--varchar(20), varchar(max) -> i�ine her t�rl� string bilgi girilebilir. Girilen bilgi ayr�lan alandan daha az ise fazla olan k�sm� haf�zadan iade eder.
--nvarchar(40) -> Ayr�lan alan�n yar�s�na girilen bilgileri al�rken, di�er yar�s�nda ise utf-8 tablo kar��l�klar�n� takip eder.
--char, text gibi  veri t�rlerinde ba�tan 8000 karakterlik yer ayr�ld���ndan genellikle varchar tercih ediyoruz.
--tinyint (byte), haf�zada 1 byte yer i�gal eder ve 0-255 aras� de�erleri girebiliriz.
--smallint, int, bigint, haf�zada 2-4-8 byte yer kaplarlar ve tamsay� de�erleri girebiliriz.
--kesirli say�larda float 4 byte yer ayr�l�r. Decimal ve Numeric veri t�rleriyle �ok b�y�k kesirli say�lar i�in haf�zada yer ay�rabiliriz.
--bit (boolean-bool), true/false, 1/0
--money, parasal de�erlerin takibinde kullan�l�r, double veri t�r�ne benzer.
--TabloAd� �zerinde sa� tu� Design, tablo tasar�m ekran�na d�nmemizi sa�lar.
--Design ekran�nda sa� tu� Indexes/Keys se�ene�inden Unique Key ve Index dosyalar� tan�mlanabilir. 
--Sa� tu� Check Constraints se�ene�inden kolonlarla ilgili k�s�tlamalar tan�mlanabilir (Age>= 18)
--K�s�tlamalar tan�mlan�rken ilgili tabloda �nceden girilmi� veriler varsa, bu k�s�tlamalarla tutarl� olmas� beklenir, aksi durumda Sql k�s�tlamalar� tablo �zerine kay�t etmeyecektir.
--DateTime t�r�nden bir kolonda Default Constraint olarak getdate() vererek, bilgi girilmedi�inde otomatik olarak sistem tarih ve saatinin at�lmas�n� sa�lar�z.
--Her iki tabloyu ili�kilendirirken Diagrams ekran�n� kullanabiliriz, kural olarak ili�ki (relation) ayn� t�rden kolonlar aras�nda kurulmal�d�r. Best Practice, Bire �ok (OneToMany) ili�kiler 1.tablonun primary key kolonu ile di�er tablonun d�� anahtar� ars�nda ger�ekle�tirilir. Di�er tablonun d�� anahtar i�in ayr�lan alan� art�k Sql Server taraf�ndan Foreign Key olarak kabul edilir.




