namespace ConsoleApp_SinifGecme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen iki notun ortalamasını hesaplayarak sınıfta kalan veya sınıfı geçenleri derecesiyle gösteren uygulamayı yazınız.

            // && - AND - VE    -> İki şartı birbirine bağlar, her iki şartın da sağlandığı (doğru olduğu) durumda sonuç doğru (true), aksi taktirde sonuç yanlıştır (false).

            // || - OR - VEYA   -> İki şartı birbirine bağlar, her iki şartın da sağlanmadığı (yanlış olduğu) durumda sonuç yanlış (false), aksi taktirde sonuç doğrudur (true).

            //ort < 50 -> kaldı
            //ort >= 50 ve ort < 60 -> CC
            //ort >= 60 ve ort < 70 -> CB
            basla:
            Console.Write("1. sınav notu : ");
            int sinav1 = int.Parse(Console.ReadLine());
            Console.Write("2. sınav notu : ");
            int sinav2 = int.Parse(Console.ReadLine());
            if(sinav1 < 0 || sinav1 > 100 || sinav2 < 0 || sinav2 > 100) {
                Console.WriteLine("Geçersiz not girişi! Sınav notunu 0-100 arasında girmelisiniz!");
                goto basla;
            }
            //Program buraya geldiyse sınav notları doğru aralıkta girilmiş demektir.
            int ort = (sinav1 + sinav2) / 2;        //not ortalaması

            if (ort >= 50 && ort < 60)
            {
                Console.WriteLine("Sınıfı {0} ortalama, CC dereceyle geçtiniz.", ort);
            }
            else if (ort >= 60 && ort < 70)
            {
                Console.WriteLine("Sınıfı {0} ortalama, CB dereceyle geçtiniz.", ort);
            }
            else if(ort >= 70 && ort < 80)
            {
                Console.WriteLine("Sınıfı {0} ortalama, BB dereceyle geçtiniz.", ort);
            }
            else if(ort >= 80 && ort < 90)
            {
                Console.WriteLine("Sınıfı {0} ortalama, BA dereceyle geçtiniz.", ort);
            }
            else if(ort >= 90 && ort <= 100)
            {
                Console.WriteLine("Sınıfı {0} ortalama, AA dereceyle geçtiniz.", ort);
            }
            else
            {
                Console.WriteLine("Sınıfta kaldınız!");
            }

            //if (ort < 50)
            //{
            //    Console.WriteLine("Sınıfta kaldınız!");
            //}
            //else if(ort < 60)
            //{
            //    Console.WriteLine("Sınıfı {0} ortalama, CC dereceyle geçtiniz.", ort);
            //}
            //else if (ort < 70)
            //{
            //    Console.WriteLine("Sınıfı {0} ortalama, CB dereceyle geçtiniz.", ort);
            //}
            //else if (ort < 80)
            //{
            //    Console.WriteLine("Sınıfı {0} ortalama, BB dereceyle geçtiniz.", ort);
            //}
            //else if (ort < 90)
            //{
            //    Console.WriteLine("Sınıfı {0} ortalama, BA dereceyle geçtiniz.", ort);
            //}
            //else
            //{
            //    Console.WriteLine("Sınıfı {0} ortalama, AA dereceyle geçtiniz.", ort);
            //}
            //if(ort < 50)
            //{
            //    Console.WriteLine("Sınıfta kaldınız!");
            //}
            //else
            //{
            //    Console.WriteLine("Sınıfı {0} ortalamayla geçtiniz.", ort);
            //}

            Console.ReadKey();
        }
    }
}