namespace WinFormsApp.EnBuyukEnKucuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] Ogrenciler = { "Vedat", "Oya", "Necati", "Gizem", "Sedat", "Hasan", "Sema", "Niyazi" };
        int[] Notlar = { 40, 55, 35, 70, 90, 65, 20, 80 };
        //Sýnýfta en yüksek not ve alan öðrenciyle, en düþük not ve alan öðrenciyi bularak ekranda gösteren kodu yazýnýz.
        int EB, EK;
        string EBAlan, EKAlan;
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("En büyük sayý = " + Notlar.Max());
            //MessageBox.Show("En küçük sayý = " + Notlar.Min());
            EB = Notlar[0];
            EK = Notlar[0];

            for (int i = 1; i < Notlar.Length; i++)
            {
                if (Notlar[i] > EB)
                {
                    EB = Notlar[i];
                    EBAlan = Ogrenciler[i];
                }
                if (Notlar[i] < EK)
                {
                    EK = Notlar[i];
                    EKAlan = Ogrenciler[i];
                }
            }
            txtEnBuyuk.Text = EB.ToString();
            txtEBOgrenci.Text = EBAlan;
            txtEnKucuk.Text = EK.ToString();
            txtEKOgrenci.Text = EKAlan;
        }
    }
}