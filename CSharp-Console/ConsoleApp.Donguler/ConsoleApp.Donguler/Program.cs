namespace ConsoleApp.ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Belirli kod bloklarını birden fazla defa çalıştırmak istediğimizde döngülerden faydalanırız.
            //For döngüleri, while, do while döngüleri, foreach döngüsü

            //For döngüsü : Genellikle tekrar sayısı belli olan döngülerdir. Belirtilen şart gerçekleştiği sürece döngü içindeki işlemler tekrarlanır. Şart sağlanmadığında döngüden çıkılır ve bir sonraki komuttan program çalışmaya devam eder.

            //for (ifade1; şart; ifade2)        ifade1  :Döngü değişkeninin başlangıç 
            //{                                          değeri verilir. Sadece for'a
            //    İşlemler...                            ilk girildiğinde 1 defa çalışır.
            //}                                 Şart    :Döngüye girmek için de, işlemler her tekrarlandığında da mutlaka şart kontrol edilir, sağlanmadığında döngü sonlanır.
            //                                  İfade2  :Döngünün değişkeninin değerini değiştirir. İlk girildiğinde çalışmaz, işlemler her tekrarlandığında çalışır.


            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Hello World!");      //i++ -> i=i+1, i+=1
            //}                                           //i-- -> i=i-1, i-=1

            //1-10 tek sayılar
            for (int i = 1; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*************");
            //1-10 çift sayılar
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("*************");
            //10-1'e doğru çift sayılar
            for (int i = 10; i > 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("*************");
            int T = 0;
            //1-10 arası sayıların toplamı
            for (int i = 1; i <= 10; i++)
            {
                //Console.WriteLine(i);
                T = T + i;
            }
            Console.WriteLine("1-10 sayıların toplamı = " + T);

            //Örnek:
            //int a = 5;
            //int b;
            //int c;
            //b = a++; /*b = a; a = a + 1; */
            //c = ++a; /*a = a + 1; c = a;*/

            //Console.WriteLine($"{a}, {b}, {c}");

            Console.ReadKey();
        }
    }
}