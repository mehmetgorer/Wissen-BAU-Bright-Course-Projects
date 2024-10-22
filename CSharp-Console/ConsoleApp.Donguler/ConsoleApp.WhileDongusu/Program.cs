namespace ConsoleApp.WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i=1;
            //for (; i <= 10;)
            //{
            //    Console.WriteLine(i); 
            //    i++ ;
            //}

            //while (şart)        //Şart sağlandığı sürece döngü içindeki işlemler yapılır.
            //{
            //    İşlemler...
            //}

            //1-10 sayıları while döngüsüyle ekrana yazan uygulama.
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Başlangıç, bitiş ve artış değerlerini klavyeden alan, arasındaki sayıları ve toplamını ekranda gösteren uygulamayı yazınız.

            Console.Write("Başlangıç : ");
            int ilk = int.Parse(Console.ReadLine());
            Console.Write("Bitiş : ");
            int son = int.Parse(Console.ReadLine());
            Console.Write("Artış : ");
            int artis = int.Parse(Console.ReadLine());

            int i = ilk;
            int t = 0;
            while (i <= son)
            {
                Console.WriteLine(i);
                t += i;
                i += artis;
            }
            Console.WriteLine("Toplam = " + t);

            Console.ReadKey();
        }
    }
}