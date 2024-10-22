using WinFormsApp.BankaHesaplari.Common;
using WinFormsApp.BankaHesaplari.Entities;
using WinFormsApp.BankaHesaplari.Interfaces;
using WinFormsApp.BankaHesaplari.Models;
using WinFormsApp.BankaHesaplari.Repositories;

namespace WinFormsApp.BankaHesaplari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HesapRepository hesapRepo = new HesapRepository();
        HesapHareketRepository hareketRepo = new HesapHareketRepository();
        List<HesapModel> liste = new List<HesapModel>();
        List<HesapHareketModel> listeHareket = new List<HesapHareketModel>();
        Hesap h;
        HesapHareket hh;
        private void Form1_Load(object sender, EventArgs e)
        {
            liste = hesapRepo.GetAllHesaplarWithMusteriler();
            HesapBilgileriGoster(liste);
        }
        private void HesapBilgileriGoster(List<HesapModel> listeHesaplar)
        {
            lvHesaplar.Items.Clear();
            if (listeHesaplar.Count > 0)
            {
                for (int i = 0; i < listeHesaplar.Count; i++)
                {
                    lvHesaplar.Items.Add(listeHesaplar[i].Id.ToString());
                    lvHesaplar.Items[i].SubItems.Add(listeHesaplar[i].HesapNo);
                    lvHesaplar.Items[i].SubItems.Add(listeHesaplar[i].Tarih);
                    lvHesaplar.Items[i].SubItems.Add(listeHesaplar[i].Adi);
                    lvHesaplar.Items[i].SubItems.Add(listeHesaplar[i].Soyadi);
                    lvHesaplar.Items[i].SubItems.Add(listeHesaplar[i].TCKNo);
                    lvHesaplar.Items[i].SubItems.Add(listeHesaplar[i].Telefon);
                    lvHesaplar.Items[i].SubItems.Add(listeHesaplar[i].Bakiye.ToString());
                    lvHesaplar.Items[i].SubItems.Add(listeHesaplar[i].HesapTuru);
                    lvHesaplar.Items[i].SubItems.Add(listeHesaplar[i].MusteriId.ToString());
                }
                lvHesaplar.Items[0].Selected = true;
            }
        }
        private void lvHesaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHesaplar.SelectedItems.Count > 0)
            {
                listeHareket = hareketRepo.GetAllHareketlerWithHesapAndMusteriByHesapId(Convert.ToInt32(lvHesaplar.SelectedItems[0].SubItems[0].Text));
                HareketleriGoster(listeHareket);
                ToplamlariGoster();
            }
        }
        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            liste = hesapRepo.GetAllHesaplarWithMusterilerByAdaGore(txtAdaGore.Text);
            HesapBilgileriGoster(liste);

        }
        private void mitmCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }
        private void rbTumHesaplar_CheckedChanged(object sender, EventArgs e)
        {
            liste = hesapRepo.GetAllHesaplarWithMusteriler();
            HesapBilgileriGoster(liste);
        }
        private void rbVadesiz_CheckedChanged(object sender, EventArgs e)
        {
            liste = hesapRepo.GetAllHesaplarWithMusterilerByHesapTuru("Vadesiz Hesap");
            HesapBilgileriGoster(liste);
        }
        private void rbVadeli_CheckedChanged(object sender, EventArgs e)
        {
            liste = hesapRepo.GetAllHesaplarWithMusterilerByHesapTuru("Vadeli Hesap");
            HesapBilgileriGoster(liste);
        }
        private void HareketleriGoster(List<HesapHareketModel> listeHareketler)
        {
            lvHareketler.Items.Clear();
            if (listeHareketler.Count > 0)
            {
                for (int i = 0; i < listeHareketler.Count; i++)
                {
                    lvHareketler.Items.Add(listeHareketler[i].Id.ToString());
                    lvHareketler.Items[i].SubItems.Add(listeHareketler[i].HesapNo);
                    lvHareketler.Items[i].SubItems.Add(listeHareketler[i].Tarih);
                    lvHareketler.Items[i].SubItems.Add(listeHareketler[i].Adi);
                    lvHareketler.Items[i].SubItems.Add(listeHareketler[i].Soyadi);
                    lvHareketler.Items[i].SubItems.Add(listeHareketler[i].Tutar.ToString());
                    lvHareketler.Items[i].SubItems.Add(listeHareketler[i].IslemTuru);
                }
            }
        }
        private void ToplamlariGoster()
        {

            double toplamYatan = 0;
            double toplamCekilen = 0;
            for (int i = 0; i < lvHareketler.Items.Count; i++)
            {
                if (lvHareketler.Items[i].SubItems[6].Text == "Yatan")
                {
                    toplamYatan += Convert.ToDouble(lvHareketler.Items[i].SubItems[5].Text);
                }
                else
                {
                    toplamCekilen += Convert.ToDouble(lvHareketler.Items[i].SubItems[5].Text);
                }
            }
            txtToplamYatan.Text = string.Format("{0:C}", toplamYatan);
            txtToplamCekilen.Text = string.Format("{0:C}", toplamCekilen);
            txtToplamBakiye.Text = string.Format("{0:C}", (toplamYatan - toplamCekilen));
            //txtToplamYatan.Text = toplamYatan.ToString();
            //txtToplamCekilen.Text = toplamCekilen.ToString();
            //txtToplamBakiye.Text = (toplamYatan - toplamCekilen).ToString();
        }
        private void btnYeniHesap_Click(object sender, EventArgs e)
        {
            txtHesapNo.Text = hesapRepo.HesapNoOlustur();
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtMusteriId.Text = lvHesaplar.SelectedItems[0].SubItems[9].Text;
            txtAdi.Text = lvHesaplar.SelectedItems[0].SubItems[3].Text;
            txtSoyadi.Text = lvHesaplar.SelectedItems[0].SubItems[4].Text;
            txtTCKNo.Text = lvHesaplar.SelectedItems[0].SubItems[5].Text;
            txtBakiye.Focus();
        }
        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            frmMusteri frm = new frmMusteri();
            frm.ShowDialog(); //frmMusteri this.close() ile kapatýldýktan sonra program buradan çalýþmaya devam eder.
            txtMusteriId.Text = Genel.musteriId.ToString();
            txtAdi.Text = Genel.musteriAdi;
            txtSoyadi.Text = Genel.musteriSoyadi;
            txtTCKNo.Text = Genel.musteriTCKNo;
            cbHesapTuru.SelectedIndex = 0;
            txtBakiye.Focus();
        }
        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            if (txtHesapNo.Text != "" && txtMusteriId.Text != "" && txtBakiye.Text != "")
            {
                h = new Hesap();
                h.HesapNo = txtHesapNo.Text;
                h.Tarih = txtTarih.Text;
                h.MusteriId = Convert.ToInt32(txtMusteriId.Text);
                h.Bakiye = Convert.ToDecimal(txtBakiye.Text);
                h.HesapTuru = cbHesapTuru.SelectedItem.ToString();
                hesapRepo.HesapEkle(h);
                hh = new HesapHareket();
                hh.HesapId = h.Id;
                hh.Tarih = h.Tarih;
                hh.MusteriId = h.MusteriId;
                hh.Tutar = h.Bakiye;
                hh.IslemTuru = "Yatan";
                hareketRepo.HesapHareketEkle(hh);
                MessageBox.Show("Hesap açýldý, bakiye iþlendi.");
                Temizle();
                HesapBilgileriGoster(hesapRepo.GetAllHesaplarWithMusteriler());
            }
        }
        private void Temizle()
        {
            txtHesapNo.Clear();
            txtTarih.Clear();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTCKNo.Clear();
            txtBakiye.Clear();
            txtMusteriId.Clear();
        }
        private void btnParaYatirCek_Click(object sender, EventArgs e)
        {
            frmParaYatirCek frm = new frmParaYatirCek();
            Genel.hesapId = Convert.ToInt32(lvHesaplar.SelectedItems[0].SubItems[0].Text);
            Genel.hesapNo = lvHesaplar.SelectedItems[0].SubItems[1].Text;
            Genel.musteriAdi = lvHesaplar.SelectedItems[0].SubItems[3].Text;
            Genel.musteriSoyadi = lvHesaplar.SelectedItems[0].SubItems[4].Text;
            Genel.musteriTCKNo = lvHesaplar.SelectedItems[0].SubItems[5].Text;
            Genel.musteriId = Convert.ToInt32(lvHesaplar.SelectedItems[0].SubItems[9].Text);
            Genel.bakiye = Convert.ToDecimal(txtToplamBakiye.Text.Substring(1));  //0.deðer TL sembolünden sonraki rakamlarý dikkate alýyor. 
            frm.ShowDialog();
            HareketleriGoster(hareketRepo.GetAllHareketlerWithHesapAndMusteriByHesapId(Genel.hesapId));
            ToplamlariGoster();
        }
        private void tsmitmYeniHesap_Click(object sender, EventArgs e)
        {
            btnYeniHesap_Click(sender, e);
        }
        private void tsmitmParaYatirCek_Click(object sender, EventArgs e)
        {
            btnParaYatirCek_Click(sender, e);
        }
    }
}