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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //Enumeration (numaralandırmalar)
        //enum isim : veritürü {ifade1, ifade2,....}
        //eğer veritürü belirtilmezse otomatik olarak int kabul edilir.

        //enum Gunler{ Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar };
        enum Gunler : byte { Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar };

        enum Subeler { Beşiktaş=1201, Taksim=1251, Kadıköy=1326, Bakırköy, Şişli=1821};
        private void Form2_Load(object sender, EventArgs e)
        {
            byte kacinciGun = (byte)Gunler.Pazar;
            string gun = Gunler.Pazar.ToString();

            MessageBox.Show(kacinciGun + ". gün = " + Gunler.Pazar);

            int subeKodu = (int)Subeler.Bakırköy;
            MessageBox.Show("Bakırköy şube kodu = " + subeKodu);

            //if (subeKodu == (int)Subeler.Taksim)
            //{

            //}

        }
    }
}
