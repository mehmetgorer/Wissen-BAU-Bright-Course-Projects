using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Koleksiyonlar;

namespace WinFormsApp_Generic_Collections
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> liste1 = new List<string>() { "Ali", "Ayşe", "Neşe"};

            List<int> liste2 = new List<int>() { 3, 5, 7, 12, 8, 9 };

            List<Musteri> musteriler = new List<Musteri>()
            {
                new Musteri() {Id=1, Adi="Hasan", Soyadi="Dertli"},
                new() {Id=2, Adi="Sezgin", Soyadi="Demir"}  //yeni versiyonlarda
            };

            foreach (Musteri item in musteriler)
            {
                //MessageBox.Show(item.Adi + " " + item.Soyadi);
                MessageBox.Show(item.ToString());
            }
        }
    }
}
