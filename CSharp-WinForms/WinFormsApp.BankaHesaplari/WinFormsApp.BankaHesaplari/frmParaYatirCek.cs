using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.BankaHesaplari.Common;
using WinFormsApp.BankaHesaplari.Entities;
using WinFormsApp.BankaHesaplari.Repositories;

namespace WinFormsApp.BankaHesaplari
{
    public partial class frmParaYatirCek : Form
    {
        public frmParaYatirCek()
        {
            InitializeComponent();
        }
        HesapHareketRepository hareketRepo = new HesapHareketRepository();
        private void frmParaYatirCek_Load(object sender, EventArgs e)
        {
            txtHesapNo.Text = Genel.hesapNo;
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtAdi.Text = Genel.musteriAdi;
            txtSoyadi.Text = Genel.musteriSoyadi;
            txtTCKNo.Text = Genel.musteriTCKNo;
            cbIslemTuru.SelectedIndex = 1;
            txtTutar.Focus();
        }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (txtTutar.Text.Trim() != "" && txtTutar.Text != "0")
            {
                if (cbIslemTuru.SelectedItem.ToString() == "Cekilen" && Convert.ToDecimal(txtTutar.Text) > Genel.bakiye)
                {
                    MessageBox.Show("Limit aşımı, Yetersiz Bakiye", $"En fazla {Genel.bakiye} TL. çekibilebilir.");
                    txtTutar.Focus();
                }
                else
                {
                    HesapHareket hh = new HesapHareket();
                    hh.Tarih = txtTarih.Text;
                    hh.HesapId = Genel.hesapId;
                    hh.MusteriId = Genel.musteriId;
                    hh.Tutar = Convert.ToDecimal(txtTutar.Text);
                    hh.IslemTuru = cbIslemTuru.SelectedItem.ToString();
                    hareketRepo.HesapHareketEkle(hh);
                    MessageBox.Show("Para hareketleri işlendi.");
                    this.Close();   //Ekran kapatılır, program buraya geldiği yerden devam eder.
                }
            }
            else { MessageBox.Show("Geçerli tutar giriniz!", "Dikkat Tutar girilmedi!"); }
        }
    }
}
