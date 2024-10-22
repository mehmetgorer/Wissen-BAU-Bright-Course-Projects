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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //Value Type (Değer Tipli), Reference Type (referans tipli)
        private void Form3_Load(object sender, EventArgs e)
        {
            //int a = 5;
            int a;
            /*DegerAl(a);*/ //Value Type değişkenlere ait değerler metotlara bit bit aktarıldığından, metotlarda yapılacak işlemler value type değişkenin değerini etkilemez.
            //DegerAl(ref a);   //Value Type değişkenin adresini göndermemizi sağlıyor, ancak parametrede de ref int olarak karşılanması gerekiyor.
            DegerAl(out a);   //Aynı ref gibi value type değişkenin adresini metoda gönderiyor, ancak değişkene ilk değer atanmasa bile hata vermeden çalışmaya devam ediyor.
            MessageBox.Show(a.ToString());
            string[] Sehirler = { "İstanbul", "Ankara", "İzmir", "Bursa", "Adana" };
            MessageBox.Show(Sehirler[0]);
            ReferansAl(Sehirler);  //Referans tipli değişkenlerin (strng dizi, object gibi) metodlara adresleri gönderildiğinden metod içindeki işlemler metod dışındaki değişkenleri de etkiliyor.
            MessageBox.Show(Sehirler[0]);
        }
        //private void DegerAl(int a)
        //{
        //    a = 10;
        //}
        //private void DegerAl(ref int a)
        //{
        //    a = 10;
        //}
        private void DegerAl(out int a)
        {
            a = 10;
        }

        private void ReferansAl(string[] Iller)
        {
            Iller[0] = "Eskişehir";
        }

    }
}
