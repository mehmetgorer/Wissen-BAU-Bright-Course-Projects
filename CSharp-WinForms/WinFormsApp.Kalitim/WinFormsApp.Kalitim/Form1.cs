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
            Bitki b = new Bitki();    //(new ile örnek nesne (instance) oluþuyor.)
            b.Beslenme = "Gübre";

            Hayvan h = new Hayvan();
            h.Hareket = "Koþar";

            Insan ins = new Insan();
            ins.Dusunur = "ara sýra";

            MessageBox.Show(h.YeniDogan());
            MessageBox.Show(ins.YeniDogan());  //OOP-4 Polymorphism (baþkalaþým)
            //Ayný isimli metodun base ve derived class'larda farklý sonuçlar üretmesine çok biçimlilik prensibi diyoruz.

            //Canli c = new Canli();  //Abstract class'lar new ile çoðaltýlýp
            //c.Beslenme = "Yakýt";  //kullanýlamaz. Ancak miras alýnabilir.

            //Kisi k = new Kisi();  
            //k.Adi = "Ali";
        }
    }
    //Insan sealed (mühürlenmiþ) class olduðundan miras alýnamaz ancak new ile istenildiði kadar yeni nesne üretilebilir.
    //public class Kisi : Insan
    //{
    //    private string _adi;
    //    private string _soyadi;

    //    public string Adi { get => _adi; set => _adi = value; }
    //    public string Soyadi { get => _soyadi; set => _soyadi = value; }
    //}
}