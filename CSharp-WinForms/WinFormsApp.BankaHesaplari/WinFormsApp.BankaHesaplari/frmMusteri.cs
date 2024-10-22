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
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }
        MusteriRepository musteriRepo = new MusteriRepository();
        Musteri m = new Musteri();
        private void frmMusteri_Load(object sender, EventArgs e)
        {
            MusterileriGoster();
        }
        private void MusterileriGoster()
        {
            lbMusteriler.DataSource = musteriRepo.GetAllMusteriler();
        }
        private void lbMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            m = lbMusteriler.SelectedItem as Musteri;
            txtAdi.Text = m.Adi;
            txtSoyadi.Text = m.Soyadi;
            txtTCKNo.Text = m.TCKNo;
            txtTelefon.Text = m.Telefon;
            txtAdres.Text = m.Adres;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            txtAdi.Focus();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            m.Adi = txtAdi.Text;
            m.Soyadi = txtSoyadi.Text;
            m.TCKNo = txtTCKNo.Text;
            m.Telefon = txtTelefon.Text;
            m.Adres = txtAdres.Text;
            musteriRepo.MusteriGuncelle(m);
            MessageBox.Show("Müşteri bilgileri güncellendi.");
            MusterileriGoster();
            Temizle();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", $"{m.Adi} {m.Soyadi} Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                musteriRepo.MusteriSil(m);
                MessageBox.Show("Müşteri bilgileri silindi.");
                MusterileriGoster();
                Temizle();
            }
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTCKNo.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            txtAdi.Focus();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text != "" && txtSoyadi.Text != "" && txtTCKNo.Text != "")
            {
                Musteri m = new Musteri();
                m.Adi = txtAdi.Text;
                m.Soyadi = txtSoyadi.Text;
                m.TCKNo = txtTCKNo.Text;
                m.Telefon = txtTelefon.Text;
                m.Adres = txtAdres.Text;
                musteriRepo.MusteriEkle(m);
                MessageBox.Show("Müşteri bilgileri eklendi.");
                MusterileriGoster();
                lbMusteriler.SelectedIndex = lbMusteriler.Items.Count - 1;
                Temizle();
            }
        }
        private void btnHesabaAktar_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text != "" && txtSoyadi.Text != "" && txtTCKNo.Text != "")
            {
                if (MessageBox.Show("Aktarmak İstiyor musunuz?", $"{txtAdi.Text} {txtSoyadi.Text} aktarılsın mı?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Genel.musteriId = m.Id;
                    Genel.musteriAdi = txtAdi.Text;
                    Genel.musteriSoyadi = txtSoyadi.Text;
                    Genel.musteriTCKNo = txtTCKNo.Text;
                    this.Close();
                }
            }
            else { MessageBox.Show("Aktarmak istedğiniz müşteriyi seçin!"); }
        }
    }
}
