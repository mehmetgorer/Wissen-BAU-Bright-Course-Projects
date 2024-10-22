namespace WinFormsApp.Toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtSayi1.Text + txtSayi2.Text);
            int s1 = Convert.ToInt32(txtSayi1.Text);
            int s2 = Convert.ToInt32(txtSayi2.Text);
            //MessageBox.Show("Toplam = " + (s1 + s2).ToString());
            int toplam = s1 + s2;
            //MessageBox.Show($"Toplam = {toplam}");
            //MessageBox.Show("Toplam = " + toplam);
            lblSonuc.Text = toplam.ToString();
        }
    }
}