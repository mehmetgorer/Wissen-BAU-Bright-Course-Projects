namespace WinFormsApp.Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Tekrar tekrar çalýþtýrma ihtiyacý duyabileceðimiz kodlarý metod (method-function) olarak düzenliyoruz ve ihtiyacýmýz olduðunda metod ismiyle çaðýrýp kullanýyoruz.
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Veriler veritabanýna kayýt (insert) edilir.
            //MessageBox.Show("Öðrenci kayýt edildi.", "Kayýt");
            Mesaj_Goruntule("Öðrenci kayýt edildi.");
            Temizle();
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            //Veritabanýndaki bilgiler deðiþtirilir (update).
            //MessageBox.Show("Öðrenci bilgileri deðiþtirildi.", "Güncelleme");
            Mesaj_Goruntule("Öðrenci bilgileri deðiþtirildi.");
            Temizle();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            //Öðrencinin veritabanýndaki bilgileri silinir (delete).
            //MessageBox.Show("Öðrenci bilgileri silindi.", "Silme");
            Mesaj_Goruntule("Öðrenci bilgileri silindi.");
            Temizle();
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefonu.Clear();
            txtAdresi.Clear();
            txtAdi.Focus();
        }
        private void Mesaj_Goruntule(string mesaj)
        {
            MessageBox.Show(mesaj);
        }

        //Metod (Method-Function) Tanýmlama

        //Eriþim Belirleyici  Geri Dönüþ Veri Türü   Metodun Ýsmi(Parametreler)
        //(access modifiers)  void - deðer dönmüyorsa
        //                    (int, string, bool gibi)
        //{
        //      iþlemler...
        //      iþlemler...
        //      return geri dönüþ deðeri;   //Eðer geriye deðer dönüyorsa.
        //}


        //Eriþim Belirleyicileri 
        //private : Sadece bulunduðu class'a özel olup, diðer class'lardan eriþilemez.
        //public  : Tüm class'lar ve projelerden eriþilebilen genel eriþim belirleyici.
        //internal: Bulunduðumuz projenin (assembly) her yerinden eriþilebilir, diðer projeþerden eriþilemez.
        //protected : Bulunduðumuz class için private ile ayný. Ancak türetilmiþ (miras alýnan) class'larda da eriþebiliyoruz.
        //internal-protected : iki özellik VEYA-OR ile bileþtirilmiþtir. Yani bulunduðu projede tüm class'lar tarafýndan eriþilebiliyorken, diðer projelerde türetilen class'larda eriþilmeye devam eder.


    }
}