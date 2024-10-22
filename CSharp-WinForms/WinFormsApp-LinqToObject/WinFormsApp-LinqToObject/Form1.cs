using System.Linq.Expressions;

namespace WinFormsApp_LinqToObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //LINQ (Language Integrated Query - Dile Entegre Edilmi� Sorgu)
        //LINQ; verinin bulundu�u ortamlarla, yaz�l�m platformlar�n�n farkl� olmas�ndan dolay� kar��m�za ��kan hata ve zaman kay�plar�n� en aza indirmek, daha tip g�venli �al��abilmek amac�yla C# i�ine entegre edilmi� sorgulama tekni�idir.
        //Veritaban�n�n t�m nesnelerinin haf�zada bir ara katmana kopyalanmas� ve kolleksiyonlar halinde yaz�l�mc�n�n kullan�m�na sunulmas� teknolojisi olan ORM (Object Relational Mapping) ile birlikte kullan�l�r.


        private void Form1_Load(object sender, EventArgs e)
        {
            //var ile de�i�ken tan�mlama
            var a = 5;  //atanan de�erden veri t�r� saptan�yor.
            //a = "Ali";  //sonradan de�i�kenin t�r�n� de�i�tiremiyoruz.
            var ad = "Ali";
            //metodlara parametre yada geri d�n�� t�r� olarak verilemiyor.
            //var bildirimini genellikle b�yle basit kullan�mlar i�in de�il, Linq sorgular�ndan d�nen �ablon tipli kolleksiyonlar yada t�r� belli olmayan (anonymous) yap�lar i�in kullan�yoruz.

            List<int> sayilar = new List<int>() { 2, 4, 6, 8, 10, 12, 14, 16 };
            lbListe.DataSource = sayilar;
            //select * from sayilar where sayi > 4
            //var Sonuc = from s in sayilar
            //            where s > 4 && s < 14
            //            select s;

            //Lambda ifadesi => (�yle ki)

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