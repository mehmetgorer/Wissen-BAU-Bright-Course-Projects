using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Metotlar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //Topla(5, 6);
            int a = 5;
            int b = 6;
            //int sonuc = Topla(5, 6);
            int sonuc = Topla(a, b);
            //MessageBox.Show("Sonuç = " + sonuc);

            //MessageBox.Show(Topla(3, 5, 7).ToString());

            //MessageBox.Show(Topla(15, 10, 20, 30, 40).ToString());
            MessageBox.Show(Topla(15, 10, 20, 30, 40, 50, 60, 4, 12, 16).ToString());
            //Aynı isimde birden fazla metod kullandığımızda metotların aşırı yüklenmesi (overloading) gerçekleşir. Derleyici metodların imzalarına bakarak hangi metodu kullanacağını belirler.
            //Metod İmzası = Metodun Adı + Parametre Sayıları + Parametrelerin veri türleri
        }

        //params parametresi bir metod için sadece 1 defa ve en son parametre olarak kullanılabilir. Metodu çağırırken parametrelerin sonuna istediğimiz kadar değer ilave etmemizi sağlar.
        private int Topla(int s1, params int[] sayilar)
        {
            //int toplam = 0;
            int toplam = s1;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }
        private int Topla(int s1, int s2)
        {
            //int sonuc = s1 + s2;
            //MessageBox.Show("Sonuç = " + sonuc);
            return s1 + s2;
        }
        private int Topla(int s1, int s2, int s3)
        {
            return s1 + s2 + s3;
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            txtSonuc.Text = Topla(sayi1, sayi2).ToString();
            //int toplam = Topla(sayi1, sayi2);
            //txtSonuc.Text = toplam.ToString();

        }
    }
}
