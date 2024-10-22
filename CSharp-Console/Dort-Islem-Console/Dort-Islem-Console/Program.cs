using System.ComponentModel.Design;

namespace Dort_Islem_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 2 sayıyı, kullanıcının istediği dört işlemden birine göre hesaplayan ve kullanıcı istediğinde sona eren programı yazınız.

            //basla:        şeklinde işaretlediğimiz satıra istediğimiz yerden
            //goto basla;   şeklinde geri dönebiliyoruz.
            //Environment.Exit(0);    //Console uygulamasını sonlandırarak programın çalışmasını bitirir.
            basla:
            Console.Write("1. sayıyı giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            menu:
            Console.WriteLine();
            Console.WriteLine("************** Dört İşlem Menüsü ***************");
            Console.WriteLine("* 1. Toplama İşlemi");
            Console.WriteLine("* 2. Çıkarma İşlemi");
            Console.WriteLine("* 3. Çarpma İşlemi");
            Console.WriteLine("* 4. Bölme İşlemi");
            Console.WriteLine("* 0. Programdan Çıkış");
            Console.WriteLine("Seçiminiz : ");

            byte secim = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
            if (secim == 1)
            {
                Console.WriteLine("Sonuç = " + (sayi1 + sayi2));
            }
            else if (secim == 2)
            {
                Console.WriteLine("Sonuç = " + (sayi1 - sayi2));
            }
            else if (secim == 3)
            {
                Console.WriteLine("Sonuç = " + (sayi1 * sayi2));
            }
            else if (secim == 4)
            {
                if (sayi2 != 0)
                {
                    Console.WriteLine("Sonuç = " + (sayi1 / sayi2));
                }
                else
                {
                    Console.WriteLine("0'a bölme yapılamaz.");
                }
            }
            else if (secim == 0)
                Environment.Exit(0);    //Blok içinde tek işlem yapıyorsak scope yani {} işaretlerini kullanmayabiliriz.
            else
            {
                Console.WriteLine("Hatalı seçim yaptınız!");
                goto menu;
            }            
            Console.ReadKey();
            Console.Clear();    //Ekranı temizler.
            goto basla;



        }
    }
}