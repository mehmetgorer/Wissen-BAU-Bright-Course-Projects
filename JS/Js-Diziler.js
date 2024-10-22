// Diziler (Arrays)

let notlar = [40, 60, 30, 90, 50, 65, 75];
let renkler = ["mavi", "yeşil", "kırmızı", "sarı"];

let sonuc;

sonuc = notlar[0];  //dizinin ilk elemanı
sonuc = notlar;
sonuc = notlar.length; //eleman sayısını verir (7).
sonuc = notlar[notlar.length - 1]; //son elemanını getirir.
//sonuc = notlar.slice(-2); //string ifadelerde her bir karakter bir elemanken, dizilerde her bir elemanı sayıyor. Yani sondan 2 elemanı getiriyor [65, 75] 

let ogrenciler = [];
ogrenciler[0] = "Ali";
ogrenciler[1] = "Ayşe";
ogrenciler[2] = "Oya";
ogrenciler[3] = "Neşe";

sonuc = ogrenciler[0];  
ogrenciler[2] = "Hasan";  //2 indeksli eleman Hasan olarak değiştirilir.
sonuc = ogrenciler[2];

ogrenciler[4] = "Sevgi";  //4 indeksli eleman olmadığından dizi büyütülüyor ve yeni eleman olarak ekleniyor.
sonuc = ogrenciler;
sonuc = ogrenciler.toString(); //diziyi string ifadeye çevirir.

// sonuc = ogrenciler.toString().split(","); //split, string ifadeyi, içindeki bir ayıraca göre diziye dönüştürür.

let telefonlar1 = ["IPhone 12", "IPhone 13"];
let telefonlar2 = ["Samsung S23", "Samsung S24"];
let telefonlar3 = ["IPhone 14"];

sonuc = telefonlar1.concat(telefonlar2); //2 dizi birleştirilir.
sonuc = telefonlar1.concat(telefonlar2, telefonlar3); 
sonuc = telefonlar2.concat(telefonlar3, "Nokia 3310", "LG G5" );  //birden fazla dizi ile birden fazla string eleman birleştirilebilir.

//dizilerin türü object olduğundan farklı türlerde eleman da ekleyebiliriz.

let modeller = ["IPhone 13", 40000, "IPhone 14", 50000, "Galaxy S23", 35000];

sonuc = modeller[1];   //40000  number
sonuc = modeller[2];   //IPhone 14 string

let telefonlar = ["IPhone 13", 40000, ["Mavi", "Siyah"],"IPhone 14", 50000, ["Yeşil", "Gri"],"Galaxy S23", 35000, ["Siyah", "Beyaz"]];

sonuc = telefonlar[2]; //2 elemanlı dizi (object)
sonuc = telefonlar[2][0]; //2 elemanlı dizinin 0. elemanı Mavi
sonuc = telefonlar[2][1]; //2 elemanlı dizinin 1. elemanı Siyah

//Dizi Fonksiyonları
sonuc = renkler;
sonuc = renkler.pop();  //dizinin son elemanını siler ve silinen elemanı geri döndürür.
sonuc = renkler.push("siyah"); //değeri dizinin sonuna ekler.
sonuc = renkler.shift(); //dizinin ilk elemanını siler ve sildiği elemanı geri döndürür.
sonuc = renkler.unshift("beyaz"); //değeri dizinin başına ekler, eleman sayısını döndürür.

sonuc = renkler;

//dizi.splice(start, deleteCount, ...items string[])
sonuc = ogrenciler.splice(2, 1);  //2.indeksten 1 adet sildi (Hasan) 
sonuc = ogrenciler.splice(2, 0, "Hüseyin");  //deleteCount:0 olduğundan silme yapılmıyor, 2. indekse Hüseyin eklendi. 
sonuc = ogrenciler.splice(0, 0, "Yaşar", renkler); //0. indeksten başlayarak hiç silme yapmadan (0) önce Yaşar sonra da renkler dizisini (4 elemanlı) ekledi.

sonuc = ogrenciler[1];  //4 elemanlı dizi
sonuc = ogrenciler[1][1]; //yeşil

sonuc = renkler.indexOf("Kırmızı"); //küçük büyük harf duyarlılığından bulamıyor ve -1 döndürüyor.
sonuc = renkler.indexOf("kırmızı"); //indeksi 2

sonuc = renkler.includes("turuncu"); //elemanı bulamadığından false döndürür.
sonuc = renkler.includes("beyaz"); //elemanı bulduğu için true döndürür.

sonuc = renkler.sort(); //dizi elemanlarını alfabetik olarak (A -> Z) sıralar.
sonuc = renkler.reverse(); //dizi elemanlarınının sıralarını ters çeviriyor yani sondaki başa gibi. 
// sonuc = sonuc.reverse(); //dizi elemanlarını alfabetik olarak tersten (Z -> A) sıralar.

sonuc = notlar.sort(); //diziyi sıraladıktan sonra
sonuc = notlar.reverse(); //ters çeviriyor, sonuç büyükten küçüğe (Z -> A) şeklinde sıralanmış oluyor.


console.log(sonuc, typeof sonuc);
