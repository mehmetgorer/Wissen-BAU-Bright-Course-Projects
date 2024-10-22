//Jquery    - $

//Jquery uzun yıllardır kullanılan en popüler javascript kütüphanesidir. Genellikle Js kullanılarak birkaç adımda gerçekleşen işlemler jquery ile çok daha kısa ve hızlı yapılabilir.

//Kullanabilmemiz için download edilip sayfamıza link verilmesi veya bir CDN linkinin sayfaya eklenmesi gerekir.

// jquery.com -> CDN sayfasından.
//   <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.7.0/jquery.min.js"></script>

//Değişken Tanımlama
$.ad;
$.ad = "Sevgi";
$.soyad = "Koşar";
$.sonuc = $.ad + " " + $.soyad;

$.product = {
    name: "Kazak",
    price: 130
}

$.sonuc = $.product.name;

//Javascript - sayfa yüklendiğinde çalışması için:
// document.onload = alert("sayfa yüklendi"); 

//Jquery - Sayfa tamamen yüklendiğinde yani hazır olduğunda çalışması için:
// $(document).ready(function() {
//     alert("Sayfa yüklendi.");
// })

//Jquery events

//click, show(), hide(), mouseenter, mouseleave, dblclick gibi.

// $(document).ready(function(){
//     $('#text').text("Sayfa Yüklendi."); //id'si text olan paragrafta verilen yazıyı görüntüler.
//     $('#text').html("<em>Sayfa Yüklendi.</em>"); //id'si text olan paragrafta verilen yazıyı görüntüler.

//     $('#degistir').click(function(){
//         $('#text').hide(1000);
//     })
// })

$(document).ready(function(){
    $('#sonuc').mouseenter(function(){
        $(this).css(
            'background', 'yellow'
        )
    });

    $('#sonuc').mouseleave(function(){
        $(this).css(
            'background', 'red'
        )
    });

    // $('.gizle').click(function(){
    //     $('#sonuc').hide(1000);
    // });

    // $('.goster').click(function(){
    //     $('#sonuc').show(1000);
    // });
})

console.log($.sonuc);