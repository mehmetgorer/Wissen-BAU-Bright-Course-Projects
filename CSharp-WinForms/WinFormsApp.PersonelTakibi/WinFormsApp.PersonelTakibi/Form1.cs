namespace WinFormsApp.PersonelTakibi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PersonelService pService = new PersonelService();
        List<Personel> personels = new List<Personel>();
        Personel p = new Personel();

        private void Form1_Load(object sender, EventArgs e)
        {
            Goster();
        }
        private void lbListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Seçilen indeks : " + lbListe.SelectedIndex);
            p = (Personel)lbListe.SelectedItem;
            //MessageBox.Show(p.Id + ", " + p.Adi + " " + p.Soyadi);
            MoveToText();
        }
        private void btnListe_Click(object sender, EventArgs e)
        {
            personels = pService.GetAllPersonel();
            lbListe.Items.Clear();
            foreach (Personel p in personels)
            {
                lbListe.Items.Add(p); //Listbox'ýn her elemanýna tüm bilgileriyle personel nesnesini ekler.

                //lbListe.Items.Add(p.Adi + " " + p.Soyadi);  //Listbox'ýn her elemanýna sadece personel adý ve soyadýný ekler.
            }
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() != "")
            {
                p = new Personel();
                p.Id = Convert.ToInt32(txtId.Text);
                p.Adi = txtAdi.Text;
                p.Soyadi = txtSoyadi.Text;
                pService.AddPersonel(p);
                MessageBox.Show("Yeni personel eklendi.");
                Goster();
                Temizle();
            }
        }
        private void Temizle()
        {
            txtId.Clear();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtId.Focus();
        }
        private void Goster()
        {
            personels = pService.GetAllPersonel();
            lbListe.Items.Clear();
            foreach (Personel p in personels)
            {
                lbListe.Items.Add(p);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lbListe.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Silmek Ýstiyor musunuz?", $"{p.Adi + " " + p.Soyadi} silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pService.DeletePersonel(p);
                    MessageBox.Show("Personel bilgileri silindi.");
                    Goster();
                    Temizle();
                }
            }
            else
            {
                MessageBox.Show("Öncelikle personel seçmelisiniz!");
            }
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (lbListe.SelectedItems.Count > 0 && txtId.Text.Trim() != "")
            {
                p.Id = Convert.ToInt32(txtId.Text);
                p.Adi = txtAdi.Text;
                p.Soyadi = txtSoyadi.Text;
                MessageBox.Show("Personel bilgileri deðiþtirildi.");
                Goster();
                Temizle();
            }
            else
            {
                MessageBox.Show("Öncelikle personel seçmelisiniz!");
            }
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() != "")
            {
                p = pService.GetPersonelById(Convert.ToInt32(txtId.Text));
                MoveToText();
                lbListe.SelectedItem = p;
                //lbListe.SelectedIndex = 0; //Listenin ilk elemanýný seçer.
            }
        }
        private void MoveToText()
        {
            txtId.Text = p.Id.ToString();
            txtAdi.Text = p.Adi;
            txtSoyadi.Text = p.Soyadi;
        }
    }
}