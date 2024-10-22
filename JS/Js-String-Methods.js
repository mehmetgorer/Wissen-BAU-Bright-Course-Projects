// Strings
let sonuc;
//console.log(sonuc);  //undefined -henüz tanımlanması bitirilmemiş, değer atanmamış değişken.

let araba = "Ali Uçar'ın arabası";
araba = 'Ali Uçar"ın arabası';  //"" içinde ' işaretini ayıraç olarak veya '' içinde " ayıraç olarak kullanabiliriz.

araba = 'Ali Uçar\'ın arabası'; //string ifadelerde \ sembolünden sonraki karakter derleyici tarafından yorumlanmaz.

//sonuc = araba;

let anaFikir = "Sakla samanı gelir zamanı";
let ilkHarf = anaFikir[0];  //string ifade bir char dizisi gibi kabul edildiğinden indeks ile harflere ulaşabiliyoruz.
let ikinciHarf = anaFikir[1];
sonuc = ikinciHarf;

sonuc = anaFikir.split(" ")[0]; //split boşluk değerine göre string ifadeyi parçalara ayırıp 4 elemanlı dizi oluşturuyor, 0 indeksiyle ilk elemana ulaşabiliyoruz.  (sakla)

sonuc = anaFikir.toUpperCase();  //büyük harfe çevirir.
sonuc = anaFikir.length;  //string ifadenin karakter sayısını verir.
sonuc = anaFikir.substring(0, 5);  //0.indeksten 5.indekse kadar karakter getirir (sakla).
sonuc = anaFikir.substring(6, 12); //6. dan 12. hariç getirir (samanı).
sonuc = anaFikir.substring(13); //13.indeksten sona kadar hepsini getirir.
sonuc = anaFikir.slice(-6, -3); //sondaki indeks -1 olursa, geriye doğru -6. indeks yani z'den sağa doğru -3. indeks hariç yani bir önceki m ye kadar alır (zam).
sonuc = anaFikir.replace("gelir", "getir");
sonuc = anaFikir.replace("gelir", "  getir   ");
sonuc = anaFikir.trim(); //string ifade içindeki gereksiz boşlukları kaldırır.

sonuc = anaFikir.indexOf("s");  //6.karakter (case sensitive - küçük büyük harf duyarlı).
sonuc = anaFikir.lastIndexOf("a"); //İfadedeki son a harfinin indeksini verir (22).
sonuc = anaFikir.indexOf("n", 11); //11. indeksten sonra ilk gelen n karakterinin indeksini verir (23);
sonuc = anaFikir.includes("saman"); //verilen ifade varsa true, yoksa false döndürür (true).
sonuc = anaFikir.includes("gelmez"); //false

console.log(sonuc, typeof sonuc);