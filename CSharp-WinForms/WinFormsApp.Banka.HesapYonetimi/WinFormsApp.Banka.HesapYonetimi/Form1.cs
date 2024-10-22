namespace WinFormsApp.Banka.HesapYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        HesapService hs = new HesapService();
        //Hesap h = new Hesap();
        HareketService hhs = new HareketService();
        List<Hesap> listeHesaplar = new List<Hesap>();
        List<HesapHareket> listeHareketler = new List<HesapHareket>();
        private void Form1_Load(object sender, EventArgs e)
        {
            YeniHesapBilgileriGetir();
            HesapBilgileriGoster();
            Temizle();
        }
        private void HesapBilgileriGoster()
        {
            lvHesaplar.Items.Clear();
            listeHesaplar = hs.HesaplariGetir();
            for (int i = 0; i < listeHesaplar.Count; i++)
            {
                lvHesaplar.Items.Add(listeHesaplar[i].Id.ToString());
                lvHesaplar.Items[i].SubItems.Add(listeHesaplar[i].HesapNo);
                lvHesaplar.Items[i].SubItems.Add(listeHesaplar[i].Tarih);
                lvHesaplar.Items[i].SubItems.Add(listeHesaplar[i].MusteriAdi);
                lvHesaplar.Items[i].SubItems.Add(listeHesaplar[i].MusteriSoyadi);
                lvHesaplar.Items[i].SubItems.Add(listeHesaplar[i].TCKimlikNo);
                lvHesaplar.Items[i].SubItems.Add(listeHesaplar[i].Bakiye.ToString());
                lvHesaplar.Items[i].SubItems.Add(listeHesaplar[i].HesapTuru);
            }
            lvHesaplar.Items[0].Selected = true;
        }
        private void btnParaYatirCek_Click(object sender, EventArgs e)
        {
            frmParaIslemleri frm = new frmParaIslemleri();
            //frm.txtHesapId.Text = txtHesapId.Text;  //Form1 new olmadýðýndan
            //frm.txtHesapNo.Text = txtHesapNo.Text;  //deðerler kaybolmadý (-1-)
            //frm.HesapBilgileriAl(txtHesapId.Text, txtHesapNo.Text);
            //frm.HesapBilgileriAl(lvHareketler.Items[0].SubItems[0].Text, lvHareketler.Items[0].SubItems[1].Text);  //(-2-) Bilgileri diðer formdaki metoda gönderebildik.
            Genel.HesapId = Convert.ToInt32(lvHareketler.Items[0].SubItems[0].Text);
            Genel.HesapNo = lvHareketler.Items[0].SubItems[1].Text;
            Genel.Bakiye = Convert.ToDouble(txtToplamBakiye.Text);
            //Static tanýmlý deðiþken veya metodlar new ile nesne oluþturulmadan Class.Deðiþken yada Class.Metod þeklinde kullanýlabilir.
            frm.ShowDialog();
            //ParaÝþlemleri ekraný kapanýnca çalýþma buradan devam eder.
            HesapHareket hh = new HesapHareket();
            hh.Id = Genel.HesapId;
            hh.HesapNo = Genel.HesapNo;
            hh.Tarih = Genel.Tarih;
            hh.Tutar = Genel.Tutar;
            hh.IslemTuru = Genel.IslemTuru;
            hhs.HesapHareketEkle(hh);
            HesapHareketleriGoster(Genel.HesapNo);
            ToplamlariGoster();
        }

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            //Hesaplar list koleksiyonuna eklenecek.
            Hesap h = new Hesap();
            h.Id = Convert.ToInt32(txtHesapId.Text);
            h.HesapNo = txtHesapNo.Text;
            h.Tarih = txtTarih.Text;
            h.MusteriAdi = txtAdi.Text;
            h.MusteriSoyadi = txtSoyadi.Text;
            h.TCKimlikNo = txtTCKNo.Text;
            h.Bakiye = Convert.ToDouble(txtBakiye.Text);
            h.HesapTuru = cbHesapTuru.SelectedItem.ToString();
            hs.HesapAc(h);
            //Hesaba yatýrýlan para için hesaphareket tanýmlayýp, hesaphareketleri kolleksiyonuna eklemeliyiz.
            HesapHareket hh = new HesapHareket();
            hh.Id = h.Id;
            hh.HesapNo = h.HesapNo;
            hh.Tarih = h.Tarih;
            hh.Tutar = h.Bakiye;
            hh.IslemTuru = "Yatan";
            hhs.HesapHareketEkle(hh);
            MessageBox.Show("Yeni hesap bilgileri açýldý.");
            HesapBilgileriGoster();
            YeniHesapBilgileriGetir();
            Temizle();
        }
        private void YeniHesapBilgileriGetir()
        {
            //Son Hesap Id bulunacak.
            txtHesapId.Text = hs.SonHesapIdBul().ToString();
            //Id'ye göre Hesap No bulunacak.
            txtHesapNo.Text = hs.HesapNoOlustur(txtHesapId.Text);
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTCKNo.Clear();
            txtBakiye.Clear();
            cbHesapTuru.SelectedIndex = 0;
            txtAdi.Focus();
        }
        private void lvHesaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHesaplar.SelectedItems.Count > 0)
            {
                HesapHareketleriGoster(lvHesaplar.SelectedItems[0].SubItems[1].Text);
                ToplamlariGoster();
            }
        }
        private void HesapHareketleriGoster(string hesapNo)
        {
            lvHareketler.Items.Clear();
            listeHareketler = hhs.HareketleriGetirByHesapNo(hesapNo);
            for (int i = 0; i < listeHareketler.Count; i++)
            {
                lvHareketler.Items.Add(listeHareketler[i].Id.ToString());
                lvHareketler.Items[i].SubItems.Add(listeHareketler[i].HesapNo);
                lvHareketler.Items[i].SubItems.Add(listeHareketler[i].Tarih);
                lvHareketler.Items[i].SubItems.Add(listeHareketler[i].Tutar.ToString());
                lvHareketler.Items[i].SubItems.Add(listeHareketler[i].IslemTuru);
            }
        }
        private void ToplamlariGoster()
        {
            double toplamYatan = 0;
            double toplamCekilen = 0;
            for (int i = 0; i < lvHareketler.Items.Count; i++)
            {
                if (lvHareketler.Items[i].SubItems[4].Text == "Yatan")
                {
                    toplamYatan += Convert.ToDouble(lvHareketler.Items[i].SubItems[3].Text);
                }
                else
                {
                    toplamCekilen += Convert.ToDouble(lvHareketler.Items[i].SubItems[3].Text);
                }
            }
            txtToplamYatan.Text = toplamYatan.ToString();
            txtToplamCekilen.Text = toplamCekilen.ToString();
            txtToplamBakiye.Text = (toplamYatan - toplamCekilen).ToString();
        }
    }
}