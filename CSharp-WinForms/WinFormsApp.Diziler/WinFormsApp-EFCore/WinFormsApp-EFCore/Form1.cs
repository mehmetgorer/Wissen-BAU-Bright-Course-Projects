namespace WinFormsApp_EFCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OkulContext _context = new OkulContext();
        Ogrenci o = new Ogrenci();
        private void Form1_Load(object sender, EventArgs e)
        {
            //cbSiniflar.DataSource = _context.Siniflar.ToList();
            foreach (Sinif s in _context.Siniflar)
            {
                cbSiniflar.Items.Add(s);
            }
            cbSiniflar.SelectedIndex = 0;
        }
        private void cbSiniflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sinif s = (Sinif)cbSiniflar.SelectedItem;
            Sinif s = cbSiniflar.SelectedItem as Sinif;
            if (s != null)
            {
                lbOgrenciler.DataSource = _context.Ogrenciler.Where(o => o.ClassId == s.Id).ToList();
                txtSinifId.Text = s.Id.ToString();
            }
        }
        private void lbOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            o = lbOgrenciler.SelectedItem as Ogrenci;
            txtOgrenciId.Text = o.Id.ToString();
            txtName.Text = o.Name;
            txtAge.Text = o.Age.ToString();
            txtTCKNo.Text = o.TCKNo;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            txtName.Focus();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            Temizle();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Name = txtName.Text;
            ogr.Age = Convert.ToByte(txtAge.Text);
            ogr.TCKNo = txtTCKNo.Text;
            ogr.ClassId = Convert.ToInt32(txtSinifId.Text);
            _context.Ogrenciler.Add(ogr);   //yeni öðrenciyi ara katmana ekler
            _context.SaveChanges();         //veritabanýna kayýt eder.
            MessageBox.Show("Öðrenci kayýt edildi.");
            Temizle();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Ogrenci o = _context.Ogrenciler.Where(x => x.Id == Convert.ToInt32(txtOgrenciId.Text)).FirstOrDefault();
            if (o != null)
            {
                o.Name = txtName.Text;
                o.Age = Convert.ToByte(txtAge.Text);
                o.TCKNo = txtTCKNo.Text;
                _context.Ogrenciler.Update(o);
                _context.SaveChanges();    
                MessageBox.Show("Öðrenci bilgileri deðiþtirildi.");
                Temizle();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Ogrenci o = _context.Ogrenciler.Where(x => x.Id == Convert.ToInt32(txtOgrenciId.Text)).FirstOrDefault();
            if (o != null)
            {
                if(MessageBox.Show("Silmek Ýstiyor musunuz?", $"{o.Name} Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _context.Ogrenciler.Remove(o); 
                    _context.SaveChanges();
                    MessageBox.Show("Öðrenci bilgileri silindi.");
                    Temizle();
                }
            }
        }
        private void Temizle()
        {
            txtName.Clear();
            txtAge.Clear();
            txtTCKNo.Clear();
            txtName.Focus();
        }
    }
}