namespace ConsoleApp.YasOrtalamasiByCinsiyet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int es = 0, ks = 0;
            int eYasTop = 0;
            int kYasTop = 0;
            string cevap;
            do
            {
            basla:
                Console.Write("Erkek-E, Kadın-K giriniz : ");
                string cns = Console.ReadLine().ToUpper();
                if (cns != "E" && cns != "K") goto basla;

                Console.WriteLine();
                Console.Write("Yaş giriniz : ");
                int yas = int.Parse(Console.ReadLine());

                if (cns == "E")
                {
                    es++; eYasTop += yas;
                }
                else
                {
                    ks++; kYasTop += yas;
                }
                Console.Write("Programı durdurmak için SON girin");
                cevap = Console.ReadLine().ToUpper();
            } while (cevap != "SON");
            if (es != 0) { Console.WriteLine("Erkeklerin sayısı {0}, Yaş Ortalaması = {1}", es, eYasTop / es); }
            if (ks != 0) { Console.WriteLine("Kadınların sayısı {0}, Yaş Ortalaması = {1}", ks, kYasTop / ks); }
            Console.ReadKey();
        }
    }
}