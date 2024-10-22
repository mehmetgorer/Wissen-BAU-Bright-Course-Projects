namespace WinFormsApp.LuckySeven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 340;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                btnStart.Text = "Stop";
                timer1.Start();
            }
            else
            {
                btnStart.Text = "Start";
                timer1.Stop();
                if (lbl1.Text == "7" && lbl2.Text == "7" && lbl3.Text == "7")
                {
                    this.Height = 640;
                    MessageBox.Show("Tebrikler hepsi 7'li!!!", "En Büyük Ýkramiye");
                    this.Height = 340;
                }
                else if(lbl1.Text == lbl2.Text && lbl1.Text == lbl3.Text)
                {
                    this.Height = 640;
                    MessageBox.Show("Tebrikler hepsi ayný!!!", "Win! Win! Win!");
                    this.Height = 340;
                }else if(lbl1.Text == lbl2.Text || lbl1.Text == lbl3.Text || lbl2.Text == lbl3.Text)
                {
                    this.Height = 640;
                    MessageBox.Show("Sadece 2'si ayný!!!", "Denemeye Devam Kazanacaksýnýz");
                    this.Height = 340;
                }
                else
                {
                    MessageBox.Show("Sayýlarýn hepsi farklý!!!", "Kaybetttiniz ama denemeye devam kazanacaksýnýz");
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl1.Text = rnd.Next(1, 10).ToString();
            lbl2.Text = rnd.Next(1, 10).ToString();
            lbl3.Text = rnd.Next(1, 10).ToString();
        }
    }
}