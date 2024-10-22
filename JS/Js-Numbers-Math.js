//Numbers

let sayi = 10.3;

//sonuc = parseInt(sayi);
sonuc = parseFloat(sayi);  //64 bitlik float alan oluşturuyor (double).

sayi = 120.3475562;

sonuc = sayi.toPrecision(6);  //tamsayı, ondalık dahil toplam 6 basamak alıyor, string döndürüyor. Son basamak da yuvarlama yapıyor.
sonuc = sayi.toFixed(2); //ondalık basamak sayısını 2 rakam olarak alıyor, yuvarlama yapıyor.

// Math sınıfı
sonuc = Math.round(12.4);   //12 ve number yuvarlama
sonuc = Math.round(12.6);   //13 ve number yuvarlama
sonuc = Math.ceil(12.2);    //13 ve number, yukarı yuvarlar.
sonuc = Math.floor(12.8);   //12 ve number, aşağı yuvarlar.
sonuc = Math.pow(2,3);      //üs alır, 8 number
sonuc = Math.max(3, 6, 9, 2, 5); //max sayıyı bulur 9
sonuc = Math.random();      //Rastgele 0-1 arasında sayı tutar, 0 dahil 1 hariç
sonuc = Math.random()*100 + 1; //1-100 arasında rastgele sayı tutar, 1 ve 100 dahil.

let sayi1 = "12";
let sayi2 = "20";
sonuc = sayi1 + sayi2;  //yanyana 1220 olarak yazar.

sonuc = Number(sayi1) + Number(sayi2);
sayi2 = "20x";
//sonuc = Number(sayi2);  //NaN -> numeric değil hatası

let isNumeric = isNaN(sayi2);   //true -> numeric değil
sonuc = isNumeric;

sayi2 = parseInt("20x");  //tamsayı olarak 20 değerini alır.
sayi2 = parseInt("x20"); //NaN hata verir.
sonuc = sayi2;  

console.log(sonuc);        
console.log(typeof sonuc); 



