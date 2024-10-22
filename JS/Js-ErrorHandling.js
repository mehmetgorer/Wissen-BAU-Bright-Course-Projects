//Error Handling (Hata Yakalama)

// try {
    //kontrol edilecek kod bloğu
    //...   
// } catch (error) {
    //hata durumunda çalışacak 
    //kod bloğu
// } finally {
    //her durumda en son çalışacak
    //kod bloğu
// }
let sonuc = "";
try {
    sonuc = yeni;  //reference Error
} catch (error) {
    sonuc = error.name; //error değişkeninin 2 özelliği var : name ve message;
    sonuc = error.message; //hata mesajı
}

let sayisal = 1;
try {
    sayisal.toUpperCase(); //TypeError, sayısal ifadeye uygulanamaz.
} catch (error) {
    sonuc = error.name + ", " + error.message;
}

//throw ile kendi hatalarımızı fırlatabiliyoruz (custom error)

let deger = "5";

try {
    if(isNaN(deger)){
        throw "değer sayısal değil";
    }
    sonuc = Number(deger);
    if(deger < 0){
        throw "değer negatif";
    }
} catch (err) {
    console.log("Hata : " + err);
}
finally{
    console.log("Girdiğiniz değeri kontrol edin.");
}

//console.log(sonuc);