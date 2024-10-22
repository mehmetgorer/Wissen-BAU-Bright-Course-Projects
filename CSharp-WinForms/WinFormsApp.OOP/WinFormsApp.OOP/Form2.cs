using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.OOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        cTelefon telefon = new cTelefon("LG", "G4");
        //cTelefon tel;
        cTelefon tel = new cTelefon();
        private void Form2_Load(object sender, EventArgs e)
        {
            //tel = new cTelefon();
            tel.Marka = "appLE";
            tel.Model = "iPhonE";

            cTelefon tel3 = new cTelefon();
            tel3 = tel;
            MessageBox.Show(tel3.Marka + ", " + tel3.Model);
            NesneAl(tel3);
            MessageBox.Show(tel3.Marka + ", " + tel3.Model);
            MessageBox.Show(tel.Marka + ", " + tel.Model);

            cTelefon tel1 = new cTelefon("Samsung", "Galaxy S23");

            //MessageBox.Show(tel.Marka + ", " + tel.Model);
            //MessageBox.Show(tel1.Marka + ", " + tel1.Model);

            //MessageBox.Show(telefon.Marka + ", " + telefon.Model);
        }
        private void NesneAl(cTelefon telefon)
        {
            telefon.Marka = "Samsung";
        }
        private void btnAramaYap_Click(object sender, EventArgs e)
        {
            if (txtTelno.Text.Trim() != "")
            {
                //tel = new cTelefon();
                MessageBox.Show(tel.AramaYap(txtTelno.Text));
            }
        }

        private void btnSms_Click(object sender, EventArgs e)
        {
            if (txtTelno.Text.Trim() != "" && txtMesaj.Text.Trim() != "")
            {
                //tel = new cTelefon();
                MessageBox.Show(tel.SmsGonder(txtTelno.Text, txtMesaj.Text));
            }
        }
    }
}
