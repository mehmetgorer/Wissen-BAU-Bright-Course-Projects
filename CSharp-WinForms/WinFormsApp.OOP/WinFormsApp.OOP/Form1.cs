namespace WinFormsApp.OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Nesneye Dayalý Programlama (Object Oriented Programming)
        //CSharp gibi nesneye dayalý programlama dillerinin genel ve en çok kullanýlan veri yapýsý class'lardýr (sýnýflar).
        //Class'larý taslak olarak, nesneleri (object) ise ürün olarak düþünebiliriz.
        //Class'larda ne gibi özelliklerin olacaðý ve bunlarla neler yapýlabileceði tasarlanýr, nesneler ise bunlara deðer vererek istediðimiz sayýda kullanmamýzý saðlarlar.
        //Nesneler class'lardan new komutu ile oluþturulurlar.
        //OOP Temel Prensipleri
        //1- Abstraction (Soyutlama),
        //2- Encapsulation (Sarmallama),
        //3- Inheritance (Kalýtým-Miras Alma),
        //4- Polymorphism (Çok Biçimlilik-Baþkalaþým)

        private void Form1_Load(object sender, EventArgs e)
        {
            Telefon tel1 = new Telefon();
            tel1.Marka = "Apple";
            tel1.Model = "IPhone 14";
            tel1.Fiyat = 50000;

            MessageBox.Show("Telefonun markasý = " + tel1.Marka + ", modeli = " + tel1.Model);
        }
    }
    public class Telefon
    {
        //Özellikler
        public string Marka;
        public string Model;
        public string Islemci;
        public float Ekran;
        public string Renk;
        public double Fiyat;
        public double Hafiza;
        public float Agirlik;

        //Class içinde nesnelerimizin bazý özelliklerini bilinçli veya bilinçsiz olarak gözardý ederiz, takip etmeyiz. Bu þekilde bazý özelliklerin dýþarýda býrakýlmasýna soyutlama (OOP-1- Abstraction) denir.

        //Metodlar

    }
}