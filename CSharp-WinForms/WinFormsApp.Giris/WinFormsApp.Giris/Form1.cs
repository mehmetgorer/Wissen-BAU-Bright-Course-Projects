namespace WinFormsApp.Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //WinForms desktop uygulamalarý olaya dayalý (event driven)uygulamalardýr.
        //Kontrollerin en popüler olaylarýna mouse çift týklanýlarak eriþilebilir.
        private void btnGiris_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello WinForms");
            MessageBox.Show("Merhaba " + txtAdi.Text);
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(txtAdi.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Form yükleniyor");
            txtAdi.Focus();
        }
    }
}