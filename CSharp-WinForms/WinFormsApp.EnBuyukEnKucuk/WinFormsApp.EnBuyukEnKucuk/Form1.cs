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
        //S�n�fta en y�ksek not ve alan ��renciyle, en d���k not ve alan ��renciyi bularak ekranda g�steren kodu yaz�n�z.
        int EB, EK;
        string EBAlan, EKAlan;
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("En b�y�k say� = " + Notlar.Max());
            //MessageBox.Show("En k���k say� = " + Notlar.Min());
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