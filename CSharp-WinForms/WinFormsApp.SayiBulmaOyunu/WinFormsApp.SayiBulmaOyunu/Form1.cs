namespace WinFormsApp.SayiBulmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int BS;
        int tahmin;
        Random rnd = new Random();
        int hak = 10;
        private void Form1_Load(object sender, EventArgs e)
        {
            BS = rnd.Next(1, 51);
        }
        private void btnDene_Click(object sender, EventArgs e)
        {
            tahmin = Convert.ToInt32(txtTahmin.Text);
            if (tahmin > BS)
            {
                MessageBox.Show("Tahmininiz Büyük", "Daha Küçük girin");
            }
            else if (tahmin < BS)
            {
                MessageBox.Show("Tahmininiz Küçük", "Daha Büyük girin");
            }
            else
            {
                MessageBox.Show("Tebrikler bildiniz.");
                BS = rnd.Next(1, 51);
            }
            txtTahmin.Clear();
        }
    }
}