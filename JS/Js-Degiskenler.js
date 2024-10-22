//Değişken Tanımlama
//var -> global değişken
//let -> scope değişken
//const -> scope aynı zamanda içeriği değiştirilemyen 

var ad = "Erkan";  //ad değişkeni global olarak açılıyor. var bildirimi nedeniyle değişken içine gelen bilginin türünü alıyor.

var ad = 5;     //redeclare

let soyad = "Hoyman";
//let soyad;      //redeclare kabul edilmez.

// soyad = 5; Number olarak kabul ediyor. Bu nedenle tür güvenliği sağlamak için TypeScript kullanılıyor.

let yas = 25;       //Number

//console.log(typeof yas); //ad değişkeninin türünü gösterir.

let tarih = new Date();

let yil = tarih.getFullYear();      //2023

// console.log(yil);
// console.log(typeof yil);

// let esitmi = (5 == "5");

// console.log(esitmi);        //true
// console.log(typeof esitmi); //boolean

let esitmi = (5 === "5"); //sadece değerlerin eşit olması yeterli değil, türleri de karşılaştırılıyor.

// console.log(esitmi);        //false
// console.log(typeof esitmi); //boolean

let sayi = 3;

// sonuc = sayi++; (sonuc = sayi; sayi = sayi + 1;)
sonuc = ++sayi; //(sayi = sayi + 1; sonuc = sayi;)

ad = "Ali";
soyad = "Uçar";
dogumYili = 2000;

// console.log("Adı : " + ad + ", Soyadı : " + soyad + ", Yaşı : " + (new Date().getFullYear() - dogumYili));

// console.log(`Adı : ${ad}, Soyadı ${soyad}, Yaşı :  ${new Date().getFullYear() - dogumYili}`);

const pi = 3.14;
//pi = 3.145654234; const ile tanımlanan değişkene tekrar değer ataması yapılamaz.
sonuc = pi;

console.log(sonuc, typeof sonuc);