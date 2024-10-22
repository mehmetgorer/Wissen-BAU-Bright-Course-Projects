using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Banka.HesapYonetimi
{
    public partial class frmParaIslemleri : Form
    {
        public frmParaIslemleri()
        {
            InitializeComponent();
        }
        private void frmParaIslemleri_Load(object sender, EventArgs e)
        {
            //Form1 frm = new Form1(); 1. başarısız yöntem -> new ile yeni nesne oluştuğundan diğer formun değerleri gelmiyor.
            //txtHesapId.Text = frm.txtHesapId.Text;
            //txtHesapNo.Text = frm.txtHesapNo.Text;
            txtHesapId.Text = Genel.HesapId.ToString();
            txtHesapNo.Text = Genel.HesapNo;
            txtTarih.Text = DateTime.Now.ToShortDateString();
            cbIslemTuru.SelectedIndex = 1;
            txtTutar.Focus();
        }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if(txtTutar.Text.Trim() != "" && txtTutar.Text != "0")
            {
                if(cbIslemTuru.SelectedItem.ToString() == "Yatan" || (cbIslemTuru.SelectedItem.ToString() == "Cekilen" && Convert.ToDouble(txtTutar.Text) < Genel.Bakiye))
                {
                    Genel.Tarih = txtTarih.Text;
                    Genel.Tutar = Convert.ToDouble(txtTutar.Text);
                    Genel.IslemTuru = cbIslemTuru.SelectedItem.ToString();
                    this.Close();   //Ekran kapatılır, program buraya geldiği yerden devam eder.
                }
                else
                {
                    MessageBox.Show("Limit aşımı", "Yetersiz Bakiye");
                }
            }

        }
        public void HesapBilgileriAl(string hesapId, string hesapNo)
        {
            txtHesapId.Text = hesapId;
            txtHesapNo.Text = hesapNo;
        }
    }
}
