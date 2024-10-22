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
            //Hata Kontrol�
            try   //Kodlar�m�z� try i�inde kontrol ediyoruz.
            {
                //txtSonuc.Text = (Convert.ToInt32(txtSayi1.Text) + Convert.ToInt32(txtSayi2.Text)).ToString();
                txtSonuc.Text = (Convert.ToInt32(txtSayi1.Text) / Convert.ToInt32(txtSayi2.Text)).ToString();
                //throw new Exception(); //Biz hata f�rlatarak cache bloklar�n�n devreye girmesini sa�l�yoruz.
            }
            catch (DivideByZeroException)  //�zel bir hata durumu
            {
                MessageBox.Show("S�f�ra b�lme yap�lamaz!", "Dikkat! 0 ile B�lme Hatas�!");
            }
            catch (FormatException)  //�zel bir hata durumu
            {
                MessageBox.Show("Say�sal de�er girmelisiniz!", "Dikkat! Format Hatas�!");
            }
            catch (Exception)  //Hata durumunda �al��acak kodlar.
            {
                MessageBox.Show("Hata ile kar��la��ld�!", "Dikkat! Genel Hata!");
            }
            finally   //mutlaka buradaki kodlar �al���r.
            {
                txtSayi1.Focus();
            }
            //Exception s�n�f� en genel hata s�n�f�d�r.
        }
    }
}