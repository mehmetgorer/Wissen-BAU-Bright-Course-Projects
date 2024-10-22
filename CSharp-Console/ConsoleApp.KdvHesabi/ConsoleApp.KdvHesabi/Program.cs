namespace ConsoleApp.KdvHesabi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fiyatı klavyeden girilen ürünün kdv (%18) tutarını ve kdvli toplam tutarını hesaplayıp gösteren console uygulamasını yazınız.
            Console.Write("Ürünün Fiyatı : ");
            //float fiyat = float.Parse(Console.ReadLine());
            float fiyat = Convert.ToSingle(Console.ReadLine());
            //float kdv = fiyat * 18 / 100;  
            float kdv = fiyat * 0.18f;  //f yada F koymazsak derleyici default olarak double kabul eder.

            double tutar = fiyat + kdv;
            Console.WriteLine($"Ürün Fiyatı {fiyat}, Kdv {kdv}, Toplam Tutar {tutar}");

            Console.ReadKey();
        }
    }
}