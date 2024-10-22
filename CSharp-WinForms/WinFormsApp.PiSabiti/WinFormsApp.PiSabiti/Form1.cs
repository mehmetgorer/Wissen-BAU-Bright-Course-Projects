namespace WinFormsApp.PiSabiti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const float Pi = 3.14f;     //constant (sabit de�er)
        float r, cevre, alan;
        //�evre = 2 * Pi * r
        //Alan = Pi * r * r
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCevre_Click(object sender, EventArgs e)
        {
            //Dairenin �evresi = 2 * Pi * r
            r = Convert.ToSingle(txtYaricap.Text);
            cevre = 2 * Pi * r;
            MessageBox.Show("Dairenin �evresi = " + cevre);
        }
        private void btnAlan_Click(object sender, EventArgs e)
        {
            //Dairenin Alan� = Pi * r * r
            r = Convert.ToSingle(txtYaricap.Text);
            alan = Pi * r * r;
            MessageBox.Show("Dairenin Alan� = " + alan);
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            r = Convert.ToSingle(txtYaricap.Text);
            if (rbCevre.Checked)
            {
                cevre = 2 * Pi * r;
                MessageBox.Show("Dairenin �evresi = " + cevre);
            }
            else      //Alan hesab�
            {
                alan = Pi * r * r;
                MessageBox.Show("Dairenin Alan� = " + alan);
            }

        }
    }
}