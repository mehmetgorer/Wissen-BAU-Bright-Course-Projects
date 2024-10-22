namespace ConsoleApp.CSharp.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Veri Türleri (Data Types)
            //Önceden Tanımlı (built-in) veri türleri
            //string, int, bool, char, decimal...
            bool dogrumu = true;
            char karakter = 'a';
            int kod = Convert.ToInt32(karakter);

            Console.WriteLine(karakter);    //char türündeki tek karakterlik bilgiyi gösterir.
            Console.WriteLine(kod);     //char türündeki karakterin unicode değerini integer olarak verir.

            //Kullanıcı Tanımlı veri türleri
            //class, structure, enum ...

            // Hafızada en küçük birim 1 bit alana yerleşir.
            //8 bit = 1 byte alana anlamlı bir karakter yerleşebilir.
            //                                                          CTS
            //byte    1 byte    0-255   unsigned (işaret tutulmuyor.)   (Byte)
            //sbyte   1 byte  -128,127    signed (işaretli)
            //short   2 byte    -32768, 32767     işaretli              Int16
            //ushort  2 byte    0-65535          işaretsiz
            //int     4 byte    -2,147,483,648, 2,147,483,647           Int32
            //long    8 byte    .....                                   Int64
            //float   4 byte    .....            F yada f harfi         Single
            //double  8 byte    .....           D yada d harfi(default) Double
            //decimal 16 byte   .....           M yada m harfi          Decimal
            //char    2 byte    'a'     key/value -> key-> unicode değeri
            //

            float pi = 3.14f;

            //Tür Dönüşümü

            byte say1 = 5;      //küçük türün büyük türe dönüştürülmesinde 
            int say2 = say1;    //sorun yaşanmaz, otomatik olarak dönüştürülür.     (implicitly - bilinçsiz dönüşüm)

            say2 = (int)say1;   //istenildiğinde küçük türü büyük türe dönüştürürken de bilinçli (explicitly) dönüşüm yapabiliriz. Kodumuz daha okunaklı hale gelir.

            int yas = 25;
            //double yasi = yas;  //büyüğe dönüştürdüğümüz için derleyici hata vermez. Ancak istersek cast (bilinçli dönüşüm) yaparak kodun daha okunaklı olmasını sağlayabiliriz.
            double yasi = (double)yas;      

            int say3 = 22;
            float say4;
            say4 = say3;

            int c1 = 5;
            byte c2;
            //c2 = c1;      //Derleyici büyük türün küçük türe bilinçsizce dönüştürülmesine izin vermez.
            c2 = (byte)c1; //Bilinçli (explicitly) olarak dönüşüme izin verir. (dönüştürülecek tür)değer;
            int c3 = 256;
            byte c4 = (byte)c3;     //veri kaybı!


            Console.WriteLine(c4);      //c3 değişkeninin ilk byte'ında hiç 1 olmadığından c4 değişkeninde 256 yerine sıfır (0) olacaktır.

            /*Console.WriteLine(byte.MaxValue);*/  //255

            int a1 = 5;     //Ram-Stack hafızada 32 bit (4 byte)
            byte a2 = 5;    //Ram-Stack hafızada 8 bit (1 byte)
            //byte b1 = 256; //Max.değer 255'den büyük olduğundan hata verir, kabul etmez.

            //Value Type (Değer Tipli)  byte, int, decimal, bool ...
            //Değer tipli değişkenler stack hafızada oluşturulur ve bilgi taşınırken bit bit değeri aktarılır. 
            //Reference Type (Referans Tipli)   class, object, nesneler, string
            //Referans tipli nesnelerde çalışma iki aşamalı olduğundan yani stack de adresi bulunup, heap hafızadan o adresteki değer ile çalışıldığından performansı daha düşüktür.
            //Ancak büyük yada kompleks verilerde bit bit aktarım uzun zaman alacağından referans tiplerin avantajı ortaya çıkar.
            //Ayrıca derleyici referans type nesnelerin değerleriyle ilgilenmediğinden yazılımcıya esneklik sağlanmış olur.
            int A = 5;
            int B = A;  //Stack hafızada A'da bulunan 5 değeri B'ye taşınır.
            A = 6;      //Sonradan A'da yapılan değişiklikten B etkilenmez.

            object o1 = "Deneme";   //Stack hafızada o1 oluşturulur, içindeki bilgi Heap hafızaya yerleşir. Stack'de ise heap hafızada adres bulunur.
            object o2 = o1;   //Stack'de o2 için ayrılan yere o1 içindeki adres taşınır. Böylece o1 ve o2, Heap hafızada aynı yeri refere etmiş olurlar. Herhangi birindeki değişiklik diğerini de etkilemiş olur.
            o1 = "Bursa";

            //object en genel veri türü olduğundan, yani tüm türler object sınıfından türetildiğinden, tüm veri türlerini object türüne atayabiliriz, işlem otomatik olarak (implicitly) gerçekleştirilir.
            object o3;
            int k = 32;
            o3 = k; // o3 = (object)k;
            //Herhangi bir veri türünün object türüne dönüştürülmesi işlemine Boxing (Kutulama) adı verilir. Tersi de UnBoxing adını alır.
            int j = (int)o3;    //unboxing

            //unboxing için önce boxing işlemi yapılmış olmalıdır,
            //boxing yapılan türe unboxing uygulanmalıdır.


       


            Console.ReadKey();
        }
    }
}