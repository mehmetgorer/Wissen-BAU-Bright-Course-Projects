namespace WinFormsApp.PiSabiti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const float Pi = 3.14f;     //constant (sabit deðer)
        float r, cevre, alan;
        //Çevre = 2 * Pi * r
        //Alan = Pi * r * r
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCevre_Click(object sender, EventArgs e)
        {
            //Dairenin Çevresi = 2 * Pi * r
            r = Convert.ToSingle(txtYaricap.Text);
            cevre = 2 * Pi * r;
            MessageBox.Show("Dairenin Çevresi = " + cevre);
        }
        private void btnAlan_Click(object sender, EventArgs e)
        {
            //Dairenin Alaný = Pi * r * r
            r = Convert.ToSingle(txtYaricap.Text);
            alan = Pi * r * r;
            MessageBox.Show("Dairenin Alaný = " + alan);
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            r = Convert.ToSingle(txtYaricap.Text);
            if (rbCevre.Checked)
            {
                cevre = 2 * Pi * r;
                MessageBox.Show("Dairenin Çevresi = " + cevre);
            }
            else      //Alan hesabý
            {
                alan = Pi * r * r;
                MessageBox.Show("Dairenin Alaný = " + alan);
            }

        }
    }
}