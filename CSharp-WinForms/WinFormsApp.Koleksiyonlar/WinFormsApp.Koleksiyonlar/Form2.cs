using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Koleksiyonlar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ArrayList alist = new ArrayList()
        {
            new Musteri(){Id=1, Adi="Ali", Soyadi="Uçar"},
            new Musteri(){Id=2, Adi="Neşe", Soyadi="Sever"},
            new Musteri(){Id=3, Adi="Oya", Soyadi="Koşar"}
        };
        Musteri m;
        private void Form2_Load(object sender, EventArgs e)
        {
            m = new Musteri();
            m.Id = 4;
            m.Adi = "Hasan";
            m.Soyadi = "Karslı";
            alist.Add(m);

            m = new Musteri();
            m = (Musteri)alist[0];  //object Musteri türüne unboxing yapılıyor.
            //m = alist[0] as Musteri;
            MessageBox.Show(m.Id + " nolu müşteri : " + m.Adi + " " + m.Soyadi);
            //MessageBox.Show(alist[0].ToString());
            foreach (Musteri mus in alist)
            {
                MessageBox.Show(mus.Adi + " " + mus.Soyadi);
            }

        }
    }
}
