namespace WinFormsApp.HataKontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //Hata Kontrolü
            try   //Kodlarýmýzý try içinde kontrol ediyoruz.
            {
                //txtSonuc.Text = (Convert.ToInt32(txtSayi1.Text) + Convert.ToInt32(txtSayi2.Text)).ToString();
                txtSonuc.Text = (Convert.ToInt32(txtSayi1.Text) / Convert.ToInt32(txtSayi2.Text)).ToString();
                //throw new Exception(); //Biz hata fýrlatarak cache bloklarýnýn devreye girmesini saðlýyoruz.
            }
            catch (DivideByZeroException)  //Özel bir hata durumu
            {
                MessageBox.Show("Sýfýra bölme yapýlamaz!", "Dikkat! 0 ile Bölme Hatasý!");
            }
            catch (FormatException)  //Özel bir hata durumu
            {
                MessageBox.Show("Sayýsal deðer girmelisiniz!", "Dikkat! Format Hatasý!");
            }
            catch (Exception)  //Hata durumunda çalýþacak kodlar.
            {
                MessageBox.Show("Hata ile karþýlaþýldý!", "Dikkat! Genel Hata!");
            }
            finally   //mutlaka buradaki kodlar çalýþýr.
            {
                txtSayi1.Focus();
            }
            //Exception sýnýfý en genel hata sýnýfýdýr.
        }
    }
}