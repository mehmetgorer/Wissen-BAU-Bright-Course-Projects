using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Structures_Enums
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        struct Urun
        {
            #region Members
            private int _id;
            private string _adi;
            private double _fiyat;
            private Renkler _renk; 
            #endregion

            public int Id { get => _id; set => _id = value; }
            public string Adi { get => _adi; set => _adi = value; }
            public double Fiyat { get => _fiyat; set => _fiyat = value; }
            public Renkler Renk { get => _renk; set => _renk = value; }
            public Urun(int id, string adi, double fiyati, Renkler rengi)
            {
                Id=id;
                Adi= adi;
                Fiyat= fiyati;
                Renk= rengi;
            }
        }
        enum Renkler : byte { beyaz, siyah, kırmızı, gri, mavi};
        private void Form3_Load(object sender, EventArgs e)
        {
            Urun urun = new Urun(1, "Polo", 850000, Renkler.beyaz);
            MessageBox.Show(urun.Adi + " arabamızın fiyatı : " + urun.Fiyat + ", rengi : " + urun.Renk);
        }
    }
}
