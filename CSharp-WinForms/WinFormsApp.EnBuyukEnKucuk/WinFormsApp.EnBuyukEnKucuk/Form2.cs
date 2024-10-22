using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.EnBuyukEnKucuk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int[] sayilar = { 5, 7, 2, 9, 15, 12, 3, 8 };
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (int sayi in sayilar)
            {
                lbIlkHali.Items.Add(sayi);
            }
            //Array.Sort(sayilar);    //Dizi elemanlarını küçükten büyüğe sıralar.
            //foreach (int sayi in sayilar)
            //{
            //    lbSirali.Items.Add(sayi);
            //}
            //Array.Reverse(sayilar); //Dizi elemanlarını tersten sıralar.

            //sayilar dizisinin elemanlarını Array.Sort kullanmadan küçükten büyüğe sıralayınız.



            lbSirali.Items.Clear();
            foreach (int sayi in sayilar)
            {
                lbSirali.Items.Add(sayi);
            }

        }

    }
}
