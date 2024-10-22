//-Bir web uygulamasından talepte (request) bulunabilmemiz için bir server nesnesinin çalışmasına ve tarayıcıdan gelecek istekleri dinlemesine ihtiyaç vardır.
//-Bunun için öncelikle sayfamıza http sınıfını dahil ediyoruz.

const http = require('http');

//-Ardından server nesnesi oluşturmalı ve dinleme yapacağımız portu belirtmeliyiz.

// const server = http.createServer();
// server.listen(5000);

//-Bu arada server nesnesi de olaya dayalı çalıştığı için (eventEmitter), server’a bağlantı (connection) olayı gerçekleştiğinde çalışacak fonksiyonu tanımlayabiliriz.

// server.on('connection', function(){
//     console.log('new connection...');
// });
// console.log("5000 port dinleniyor...");

//-Programı çalıştırdığımızda server nesnesi 5000 nolu portu dinlemeye başlayacak, tarayıcıda localhost:5000 üzerinden talepte bulunduğumuzda connection olayı gerçekleştiğinden “new connection” mesajı görüntülenecektir.

//-Server nesnesi oluştururken bir fonksiyonla tarayıcıdan yapılan talep (request) ve ona cevap olarak hazırlanan yanıt (response) bilgilerini yakalayabiliriz.
//-Örnek olarak request bilgileri içinden bazılarını görüntüleyelim:

const server = http.createServer((req, res) => {
    // console.log(req.url, req.method); önce
    if(req.url === "/"){    //sonra
        res.write("Home");
        res.end();
    }
    if(req.url === "/users"){
        res.write("User List");
        res.end();
    }
});
server.listen(5000);

server.on('connection', function(){
    console.log('new connection...');
});
console.log("5000 port dinleniyor...");

// Çalıştırdığımızda server dinlemeye geçecek ve localhost:5000 den talepte bulunduğumuzda;
// 	/	GET			cevaplarını alırız.

// Örneğin request – url bilgisini kontrol ederek farklı yönlendirmeler yapabiliriz.

//localhost:5000 sayfasında İncele (F12) yap ve Network sekmesinde sayfayı yenileyerek localhost request ve response oluşmasını sağla ve Header, Request ve Response bilgilerini incele.