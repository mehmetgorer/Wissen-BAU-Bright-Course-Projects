namespace ConsoleApp.CSharp.Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System    En genel kütüphane
            //Console   Console uygulamalarımızda kullanacağımız metodları bulunduran alt kütüphane
            //WriteLine() Console uygulamalarında parantez içinde belirtilen bilgi yada değişkenleri ekrana yazar ve imleç alt satıra geçer.
            //Write() Console uygulamalarında parantez içinde belirtilen bilgi yada değişkenleri ekrana yazar ve imleç aynı satırda kalır.
            //Satırı açıklama olarak kabul eder ve dikkate almaz.
            //System.Console.WriteLine("Hello World!");

            //Console.WriteLine("Hello World!");

            //Veri Türleri (Data Types)
            //string    Her türlü karakterleri kapsar. "bilgi"
            //int       Tamsayılar için kullanıyoruz.

            //Değişkenler
            //Veritürü DeğişkenAdı;
            string adi;
            string ilkAdi;
            string ilkAdi1;

            adi = "Erkan";      //kullanmadan önce değer atamamız gerekir.
            ilkAdi = adi;
            string soyadi = "Hoyman";

            //string 5A;          //Değişken ismi sayıyla başlayamaz, hatalı.
            //string A 5;           //Değişken isminde boşluk kullanılmaz.
            //string A*;              //Değişken isminde sembol kullanılamaz.

            //Console.Write("Merhaba " + adi);    //string ifadelerde + operatörü birleştirme görevini yapar.
            //Console.WriteLine();   //Boş satır bırakır.

            int s1;
            s1 = 5;
            int s2 = 8;
            int toplam;
            toplam = s1 + s2;

            //Console.WriteLine(toplam);
            //Console.WriteLine("Toplamı = " + s1+ s2);   //string ve int türünde bilgiler olduğundan + operatörü toplama değil birleştirme yapıyor.

            //Console.WriteLine("Toplamı = " + (s1 + s2));

            //Console.WriteLine("1.sayı:{0}, 2.sayı:{1}, toplamı:{2}",s1,s2,toplam);

            //Console.WriteLine($"1.sayı:{s1}, 2.sayı:{s2}, toplamı:{toplam}");

            //Console.Write("Adınızı giriniz : ");
            //string isim =Console.ReadLine();    //Enter'a basıldığında girilen bilgi string olarak soldaki değişkene aktarılır.
            //Console.WriteLine("Merhaba " + isim);

            //Klavyeden girilen iki sayının toplamını hesaplayan console uygulaması

            //Console.Write("1.sayı : ");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.Write("2.sayı : ");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.Write(sayi1 + sayi2);

            //Yaş Hesabı
            //Console.Write("Doğum yılı : ");
            //int dogumYili = int.Parse(Console.ReadLine());
            Console.Write("Doğum tarihinizi giriniz (01.01.1999): ");
            DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
            //int yas = 2023 - dogumYili;
            //int yas = DateTime.Now.Year - dogumYili;
            int yas = DateTime.Now.Year - dogumTarihi.Year;
            Console.WriteLine("Yaşınız : " + yas);

            Console.ReadKey();

        }
    }
}

