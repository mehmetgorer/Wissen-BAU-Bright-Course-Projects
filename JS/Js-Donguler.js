//Döngüler (loops)
let sonuc;
let toplam=0;
// for (let i = 1; i <= 10; i++) {
//   console.log(i);
//   toplam += i;
// }

let sayilar = [5, 10, 15, 20, 25, 30, 35, 40];

toplam = 0;
// for (let index = 0; index < sayilar.length; index++) {
//    console.log(sayilar[index]);
//    toplam = toplam + sayilar[index];  
//    //toplam += sayilar[index];
// }

toplam=0;
//for-in -> dizi içerisinde dolaşıp elemanların indekslerini getirir (indeks değişkenine koyar).

// for(let indeks in sayilar)
// {
//     // console.log(indeks);
//     toplam+= sayilar[indeks];
// }

//for-of -> (c# foreach gibi) dizi içerisinde dolaşıp elemanların değerlerini getirir (sayi değişkenine koyar).

// for(let sayi of sayilar)
// {
//     console.log(sayi);
//     toplam += sayi;
// }
let i = 1;
while (i < 5) {
    console.log("hello Js");
    i++;
}

//1-100 arası sayılardan çift olanları listeleyen, ancak 10 ve 10'un katlarını göstermeyen, göstermediği 10 değerleri 5 tane olduğunda listelemeyi bitiren while döngüsünü yazınız.
// i = 1;
// let say = 0;
// while (i < 100) {
//     if(i % 10 == 0){    //10 ve 10'un katları (yani 10'a tam bölünenler)
//         say++;  
//         i++;
//         if(say == 5) {
//             break;          //döngüden çıkar.
//         }else{ 
//             continue;   //while satırına döner.
//         }
//     }
//     if(i % 2 == 0){     //çift sayılar
//         console.log(i);
//     }
//     i++;
// }

//break döngüden çıkmayı sağlar, continue ise döngüyü sonlandırmadan işleyişi tekrar şart (condition) bölümüne döndürür.
i=5;
do      //en az bir defa döngü çalışır.
{
    console.log(i);
}while(i > 5);

sonuc = toplam;

console.log(sonuc, typeof sonuc);

