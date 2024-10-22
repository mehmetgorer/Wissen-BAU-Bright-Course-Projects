namespace WinFormsApp.OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Nesneye Dayal� Programlama (Object Oriented Programming)
        //CSharp gibi nesneye dayal� programlama dillerinin genel ve en �ok kullan�lan veri yap�s� class'lard�r (s�n�flar).
        //Class'lar� taslak olarak, nesneleri (object) ise �r�n olarak d���nebiliriz.
        //Class'larda ne gibi �zelliklerin olaca�� ve bunlarla neler yap�labilece�i tasarlan�r, nesneler ise bunlara de�er vererek istedi�imiz say�da kullanmam�z� sa�larlar.
        //Nesneler class'lardan new komutu ile olu�turulurlar.
        //OOP Temel Prensipleri
        //1- Abstraction (Soyutlama),
        //2- Encapsulation (Sarmallama),
        //3- Inheritance (Kal�t�m-Miras Alma),
        //4- Polymorphism (�ok Bi�imlilik-Ba�kala��m)

        private void Form1_Load(object sender, EventArgs e)
        {
            Telefon tel1 = new Telefon();
            tel1.Marka = "Apple";
            tel1.Model = "IPhone 14";
            tel1.Fiyat = 50000;

            MessageBox.Show("Telefonun markas� = " + tel1.Marka + ", modeli = " + tel1.Model);
        }
    }
    public class Telefon
    {
        //�zellikler
        public string Marka;
        public string Model;
        public string Islemci;
        public float Ekran;
        public string Renk;
        public double Fiyat;
        public double Hafiza;
        public float Agirlik;

        //Class i�inde nesnelerimizin baz� �zelliklerini bilin�li veya bilin�siz olarak g�zard� ederiz, takip etmeyiz. Bu �ekilde baz� �zelliklerin d��ar�da b�rak�lmas�na soyutlama (OOP-1- Abstraction) denir.

        //Metodlar

    }
}