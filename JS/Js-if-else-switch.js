//Karar Verme - Conditions

let not1 = 40;
let not2 = 60;
let ort = (not1 + not2) / 2;

if (ort < 50) {
    console.log("sınıfta kaldınız");
} else {
    console.log("sınıfı geçtiniz");
}

let s1 = 23;
let s2 = 25;
let s3 = 28;

if (s1 > s2 && s1 > s3) {
    console.log(`en büyük ${s1}`);
}
else if (s2 > s1 && s2 > s3) {
    console.log(`en büyük ${s2}`);
}
else if (s3 > s1 && s3 > s2) {
    console.log(`en büyük ${s3}`);
}
else {
    console.log(`sayılar eşittir`);
}

let kacinciGun, day;
//kacinciGun = 1;
kacinciGun = new Date().getDay();  //2->Salı

switch (kacinciGun) {
    case 0:
        day = "Pazar";
        break;
    case 1:
        day = "Pazartesi";
        break;
    case 2:
        day = "Salı";
        break;
    case 3:
        day = "Çarşamba";
        break;
    default:
        day = "Diğer Günler"
        break;
}
let sonuc = day;

console.log(sonuc);