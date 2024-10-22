namespace ConsoleApp.CSharp.If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Karar verme (akış diyagramı (flowchart) baklava sembolü)

            //if(şart)    şart ->   (==, !=, >, <, >=, <=)  
            //{
            //    işlemler...   şart gerçekleşirse bu işlemler çalıştırılır.
            //}
            //else
            //{
            //    işlemler...   gerçekleşmezse bu işlemler çalıştırılır.
            //}

            //Klavyeden girilen 2 sayıdan büyük olanı ekrana yazdıran program.
            Console.Write("1. sayı : ");
            int s1 = int.Parse(Console.ReadLine());
            Console.Write("2. sayı : ");
            int s2 = int.Parse(Console.ReadLine());

            //if (s1 > s2)
            //{
            //    Console.Write("1.sayı {0} daha büyük", s1);
            //}
            //else
            //{
            //    Console.Write("2.sayı {0} daha büyük", s2);
            //}
            //if (s1 > s2)
            //{
            //    Console.Write("1.sayı {0} daha büyük", s1);
            //}
            //if (s2 > s1)
            //{
            //    Console.Write("2.sayı {0} daha büyük", s2);
            //}
            //if (s2 == s1)
            //{
            //    Console.Write("Sayılar eşittir.");
            //}
            //Herbir şart için ayrı if kullanımı doğru sonuç verir ancak ilk şart sağlansa bile diğerlerini de kontrol etmeye devam ederek performans kaybına neden olur.
            //if (s1 > s2)
            //{
            //    Console.Write("1.sayı {0} daha büyük", s1);
            //}
            //else
            //{
            //    if (s2 > s1)
            //    {
            //        Console.Write("2.sayı {0} daha büyük", s2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayılar eşittir.");
            //    }
            //}

            if (s1 > s2)
            {
                Console.Write("1.sayı {0} daha büyük", s1);
            }
            else if (s2 > s1)
            {
                Console.Write("2.sayı {0} daha büyük", s2);
            }
            //else if (s1 == s2)
            //{
            //    Console.WriteLine("Sayılar eşittir.");
            //}
            else
            {
                Console.WriteLine("Sayılar eşittir.");
            }



            Console.ReadKey();
        }
    }
}