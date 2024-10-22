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
            //Tekrar tekrar �al��t�rma ihtiyac� duyabilece�imiz kodlar� metod (method-function) olarak d�zenliyoruz ve ihtiyac�m�z oldu�unda metod ismiyle �a��r�p kullan�yoruz.
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Veriler veritaban�na kay�t (insert) edilir.
            //MessageBox.Show("��renci kay�t edildi.", "Kay�t");
            Mesaj_Goruntule("��renci kay�t edildi.");
            Temizle();
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            //Veritaban�ndaki bilgiler de�i�tirilir (update).
            //MessageBox.Show("��renci bilgileri de�i�tirildi.", "G�ncelleme");
            Mesaj_Goruntule("��renci bilgileri de�i�tirildi.");
            Temizle();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            //��rencinin veritaban�ndaki bilgileri silinir (delete).
            //MessageBox.Show("��renci bilgileri silindi.", "Silme");
            Mesaj_Goruntule("��renci bilgileri silindi.");
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

        //Metod (Method-Function) Tan�mlama

        //Eri�im Belirleyici  Geri D�n�� Veri T�r�   Metodun �smi(Parametreler)
        //(access modifiers)  void - de�er d�nm�yorsa
        //                    (int, string, bool gibi)
        //{
        //      i�lemler...
        //      i�lemler...
        //      return geri d�n�� de�eri;   //E�er geriye de�er d�n�yorsa.
        //}


        //Eri�im Belirleyicileri 
        //private : Sadece bulundu�u class'a �zel olup, di�er class'lardan eri�ilemez.
        //public  : T�m class'lar ve projelerden eri�ilebilen genel eri�im belirleyici.
        //internal: Bulundu�umuz projenin (assembly) her yerinden eri�ilebilir, di�er proje�erden eri�ilemez.
        //protected : Bulundu�umuz class i�in private ile ayn�. Ancak t�retilmi� (miras al�nan) class'larda da eri�ebiliyoruz.
        //internal-protected : iki �zellik VEYA-OR ile bile�tirilmi�tir. Yani bulundu�u projede t�m class'lar taraf�ndan eri�ilebiliyorken, di�er projelerde t�retilen class'larda eri�ilmeye devam eder.


    }
}