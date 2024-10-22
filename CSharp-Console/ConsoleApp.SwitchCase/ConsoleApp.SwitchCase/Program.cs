namespace ConsoleApp.SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Klavyeden mevsim bilgisi girildiğinde o mevsime ait ayları gösteren kodları yazınız.
        //ToLower() -> string ifadeleri küçük harfe çevirir.
        //ToUpper() -> string ifadeleri büyük harfe çevirir.
        basla:
            Console.Write("Mevsimi giriniz : ");
            string mevsim = Console.ReadLine().ToLower();

            //if(mevsim == "kış") 
            //{
            //    Console.WriteLine("Kış ayları : Aralık, Ocak, Şubat");
            //}
            //else if (mevsim == "yaz")
            //{
            //    Console.WriteLine("Yaz ayları : Haziran, Temmuz, Ağustos");
            //}
            //else if (mevsim == "sonbahar")
            //{
            //    Console.WriteLine("Sonbahar ayları : Eylül, Ekim, Kasım");
            //}
            //else if (mevsim == "ilkbahar")
            //{
            //    Console.WriteLine("İlkbahar ayları : Mart, Nisan, Mayıs");
            //}
            //else
            //{
            //    Console.WriteLine("Mevsim bilgisini yanlış girdiniz!");
            //    goto basla;
            //}

            switch (mevsim)
            {
                case "kış":
                    Console.WriteLine("Kış ayları : Aralık, Ocak, Şubat");
                    break;
                case "yaz":
                    Console.WriteLine("Yaz ayları : Haziran, Temmuz, Ağustos");
                    break;
                case "ilkbahar":
                    Console.WriteLine("İlkbahar ayları : Mart, Nisan, Mayıs");
                    break;
                case "sonbahar":
                    Console.WriteLine("Sonbahar ayları : Eylül, Ekim, Kasım");
                    break;
                default:
                    Console.WriteLine("Mevsim bilgisini yanlış girdiniz!");
                    goto basla;
                    break;
            }

            Console.ReadKey();

            //Ödevler
            //Akış diyagramlarında en son yaptığımız erkeklerin/kadınların sayısı ve yaş ortalaması örneğinin console kodlarını yazınız.
            //Sınıf Geçme (Girilen 2 sınav notunun ortalamasını hesaplayıp geçme derecesinigösteren uygulamayı yazınız (AND-OR kullanılmayacak).
            //0-49      Kaldı
            //50-59     CC
            //60-69     CB
            //70-79     BB
            //80-89     BA
            //90-100    AA

        }
    }
}