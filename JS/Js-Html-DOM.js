//DOM - Document Object Model

//Html document sınıfı tüm html nesnelerini kapsar. Bu nedenle komutların başında document kullanıyoruz.
let sonuc = "";

sonuc = document.getElementById("id"); //verilen id'ye sahip elementi object olarak elde ediyoruz.

sonuc = document.getElementsByClassName("class"); //verilen class ismine sahip elementleri collection nesnesi olarak elde ediyoruz.

sonuc = document.getElementsByTagName("tag"); //verilen etiket ismine sahip elementleri collection nesnesi olarak elde ediyoruz.

//Tekli Element Seçimi

sonuc = document.getElementById("giris").innerText;

document.getElementById("giris").innerText = "<b>Html elementleri bulma</b>";
//innerText : Normal text ifadelerini görüntülüyor, ancak html komutlarını yorumlamıyor.
//Bunun için innerHTML özelliğini kullanıyoruz.
document.getElementById("giris").innerHTML = "<b>Html elementleri bulma</b>";

sonuc = document.getElementById("baslik");  //h2
sonuc = document.getElementById("baslik").style.color = "blue";  //id'si baslik olan elementin (h2) color özelliğini (style-css) mavi yapar.

let h2 = document.getElementById("baslik");
h2.style.background = "yellow"; 

let yazi = document.querySelector("#sonuc");

sonuc = yazi.innerHTML;

yazi = document.querySelector(".egik");

sonuc = yazi.innerHTML;

yazi = document.querySelector("div");

sonuc = yazi.innerHTML;

let li = document.querySelector("li");  //querySelector tek element döndürdüğünden ilk li objesini döndürür.
li = document.querySelector("li:first-child");  
li = document.querySelector("li:last-child");   
li = document.querySelector("li:nth-child(2)");   

sonuc = li;

//Çoklu Element Seçimi
let yazilar = document.getElementsByTagName("p"); //sayfadaki p'lerin hepsini içeren bir collection döndürüyor.

sonuc = yazilar[1].innerHTML; //2.sıradaki p etiketinin içinde bulunan metni çekiyoruz.
yazilar[0].style.fontSize = "24px";

sonuc = document.getElementsByClassName("item");
document.getElementsByClassName("item")[2].style.color = "blue";

// for (let item of sonuc){
//     item.style.color = "orange";
// }

let ul = document.getElementById("liste1");
sonuc = ul.getElementsByTagName("li"); //Sadece id'si liste1 olan ul içindeki li elemanları sonuc değişkenine aktarılır.

for (let item of sonuc){
    item.style.color = "orange";
}
//Çoklu Element Seçimi
sonuc = document.querySelectorAll("#liste2 li");

for (let item of sonuc){
    item.style.color = "blue";
}

//Events (Olaylar)

//<element event="javascript kodları">

//Html olayları 
//onchange(), onclick(), onmouseover(), onmouseout, onkeydown(), onload() gibi.

//document.onload = alert("Sayfa yüklendi.");

console.log(sonuc);