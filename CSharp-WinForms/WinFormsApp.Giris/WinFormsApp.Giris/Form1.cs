namespace WinFormsApp.Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //WinForms desktop uygulamalar� olaya dayal� (event driven)uygulamalard�r.
        //Kontrollerin en pop�ler olaylar�na mouse �ift t�klan�larak eri�ilebilir.
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
            //MessageBox.Show("Form y�kleniyor");
            txtAdi.Focus();
        }
    }
}