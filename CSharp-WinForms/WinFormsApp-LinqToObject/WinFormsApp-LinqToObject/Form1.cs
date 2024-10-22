using System.Linq.Expressions;

namespace WinFormsApp_LinqToObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //LINQ (Language Integrated Query - Dile Entegre Edilmiþ Sorgu)
        //LINQ; verinin bulunduðu ortamlarla, yazýlým platformlarýnýn farklý olmasýndan dolayý karþýmýza çýkan hata ve zaman kayýplarýný en aza indirmek, daha tip güvenli çalýþabilmek amacýyla C# içine entegre edilmiþ sorgulama tekniðidir.
        //Veritabanýnýn tüm nesnelerinin hafýzada bir ara katmana kopyalanmasý ve kolleksiyonlar halinde yazýlýmcýnýn kullanýmýna sunulmasý teknolojisi olan ORM (Object Relational Mapping) ile birlikte kullanýlýr.


        private void Form1_Load(object sender, EventArgs e)
        {
            //var ile deðiþken tanýmlama
            var a = 5;  //atanan deðerden veri türü saptanýyor.
            //a = "Ali";  //sonradan deðiþkenin türünü deðiþtiremiyoruz.
            var ad = "Ali";
            //metodlara parametre yada geri dönüþ türü olarak verilemiyor.
            //var bildirimini genellikle böyle basit kullanýmlar için deðil, Linq sorgularýndan dönen þablon tipli kolleksiyonlar yada türü belli olmayan (anonymous) yapýlar için kullanýyoruz.

            List<int> sayilar = new List<int>() { 2, 4, 6, 8, 10, 12, 14, 16 };
            lbListe.DataSource = sayilar;
            //select * from sayilar where sayi > 4
            //var Sonuc = from s in sayilar
            //            where s > 4 && s < 14
            //            select s;

            //Lambda ifadesi => (öyle ki)

            //var Sonuc = sayilar.Where(s => s > 4 && s < 14).Select(s => s);

            var Sonuc = sayilar.Where(s => s > 4 && s < 14);

            //foreach ( int s in Sonuc )
            //{
            //    lbSonuc.Items.Add( s );
            //}
            lbSonuc.DataSource = Sonuc.ToList();
        }
    }
}