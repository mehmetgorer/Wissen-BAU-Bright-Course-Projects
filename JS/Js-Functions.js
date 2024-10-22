//Functions 

//function fonksiyonAdi(Parametreler) {
    //js kodları
    //return değer;     (geriye değer dönecekse)
//}

//Parametresiz fonksiyon

function goster() {
    console.log("Merhaba Javascript");
}

goster();  //fonksiyonların çalışması için çağrılması gerekir.

//Parametreli fonksiyon

function msgGoster(msg){
    console.log(msg);
}

msgGoster("Hoşgeldiniz"); //Fonksiyonu parametre göndererek çalıştırıyoruz.

//Parametreli ve geriye değer döndüren fonksiyon

function hesapla(s1, s2){
    return s1 + s2;
}

sonuc = hesapla(12, 22);        //34
sonuc = hesapla(2, 12);        //14

function yasHesapla(dogumYili){
    return new Date().getFullYear() - dogumYili;
}

sonuc = yasHesapla(1995);
sonuc = yasHesapla(2005);


let person = {
    firstname : "Neşe",
    lastname : "Sever",
    fullname : function() {
        return this.firstname + " " + this.lastname;
    }
}

sonuc = person.firstname;
sonuc = person.fullname;    //fonksiyona karşılık gelir.
sonuc = person.fullname();  //Neşe Sever

//object tanımları içinde function kullanabiliriz, js bu fonksiyonları metod olarak yorumluyor.

//this keyword : Javascripte tek başına ve globalde kullanıldığında global değişkene karşılık gelir, ancak object içinde tanımlandığı nesneyi temsil eder.
//
let a1 = 5;
var a2 = 5;
//this globalde yalnız kullanıldığında window global kütüphanesi elde edilir.
//this.a1 ve this.a2 ulaşılıyor, ancak let ile tanımlanan değişkenler undefined hatası veriyor.
// var ile tanımlanan global değişkenleri değerleriyle birlikte elde edebiliyoruz.
//sonuc = this;

//scope
//global scope, function scope, block scope

//Block scope (if, for gibi { scope }), let, const için geçerli (2015 yılında çıkan ES6 versiyonundan itibaren)

if(true){           //block scope
    let deger1 = 5;
}

//sonuc = deger1;      //global scope
//let ve const için hata verir. İçerde tanımlanan değişkenler dışarıda kullanılamaz.

if(true)
{
    var deger2 = 6;
}

sonuc = deger2;     //var değişkenleri block scope'tan etkilenmiyor, global olarak işlem görüyor.

function scope(){
    let deger3 = 2;
    var deger4 = 3;
}

//sonuc = deger3;  //iki kullamı da hata veriyor. let, const ve var için function scope aynı.
//sonuc = deger4;

let bilgi1 = "global";  //global değişken
function deneme1(){
    let bilgi1 = "func scope"; //func scope
    //console.log(bilgi1);
}

//sonuc = deneme1();
sonuc = bilgi1;

var bilgi2 = "global";  //global değişken
function deneme2(){
    bilgi2 = "func scope"; //global değişken yani yukarıda tanımlanan
    //console.log(bilgi2);
}

sonuc = deneme2();
sonuc = bilgi2;     //değeri değişir - func scope

function autoGlobal(){
    yeniUrun = "Bilgisayar";
}

//sonuc = yeniUrun; //hata verir, function çalışmadığından değişkeni görmüyor.

autoGlobal();

sonuc = yeniUrun; //değişken otomatik olarak global kabul ediliyor.


console.log(sonuc);