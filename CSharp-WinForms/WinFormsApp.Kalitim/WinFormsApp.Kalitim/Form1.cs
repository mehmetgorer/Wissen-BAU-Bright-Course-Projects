namespace WinFormsApp.Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Bitki b = new Bitki();    //(new ile �rnek nesne (instance) olu�uyor.)
            b.Beslenme = "G�bre";

            Hayvan h = new Hayvan();
            h.Hareket = "Ko�ar";

            Insan ins = new Insan();
            ins.Dusunur = "ara s�ra";

            MessageBox.Show(h.YeniDogan());
            MessageBox.Show(ins.YeniDogan());  //OOP-4 Polymorphism (ba�kala��m)
            //Ayn� isimli metodun base ve derived class'larda farkl� sonu�lar �retmesine �ok bi�imlilik prensibi diyoruz.

            //Canli c = new Canli();  //Abstract class'lar new ile �o�alt�l�p
            //c.Beslenme = "Yak�t";  //kullan�lamaz. Ancak miras al�nabilir.

            //Kisi k = new Kisi();  
            //k.Adi = "Ali";
        }
    }
    //Insan sealed (m�h�rlenmi�) class oldu�undan miras al�namaz ancak new ile istenildi�i kadar yeni nesne �retilebilir.
    //public class Kisi : Insan
    //{
    //    private string _adi;
    //    private string _soyadi;

    //    public string Adi { get => _adi; set => _adi = value; }
    //    public string Soyadi { get => _soyadi; set => _soyadi = value; }
    //}
}