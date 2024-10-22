//Objects (Nesneler)
//Yazım şekli Dictionary -> key-value gibi yada Json formatı gibidir.

const user = {
    firstName : "Oya",
    lastName : "Koşar",
    age : 30
}

sonuc = user.firstName;
sonuc = user.age;
//sonuc = user["age"];  //key=age -> value getir.

const ogrenci = {
    firstName : "Oya",
    lastName : "Koşar",
    age : 30,
    address : {
        sehir : "İstanbul",
        ilce : "Beşiktaş"
    }
}

sonuc = ogrenci.address.sehir;
sonuc = ogrenci.address.ilce;

let products = [
    {
        name : "Bilgisayar",
        price : 40000
    },
    {
        name : "Yazıcı",
        price : 5000
    }
];

sonuc = products[1].name;   //Yazıcı
sonuc = products[0].price;  //40000


console.log(sonuc, typeof sonuc);