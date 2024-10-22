namespace WinFormsApp.AtYarisi
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
            pb1.Left = 24;
            pb2.Left = 24;
            pb3.Left = 24;
            pb4.Left = 24;
            btnStart.Left = 24;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pb1.Left = 24;
            pb2.Left = 24;
            pb3.Left = 24;
            pb4.Left = 24;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pb1.Left += rnd.Next(1, 10);     //1-9 arasý rastgele sayý üretir.
            pb2.Left += rnd.Next(1, 10);
            pb3.Left += rnd.Next(1, 10);
            pb4.Left += rnd.Next(1, 10);

            if (pb1.Left >= this.Width - pb1.Width - 15)
            {
                timer1.Stop();
                MessageBox.Show("1.at kazandý!!!", "ÞAMPÝYON -1-");
            }
            else if (pb2.Left >= this.Width - pb2.Width - 15)
            {
                timer1.Stop();
                MessageBox.Show("2.at kazandý!!!", "ÞAMPÝYON -2-");
            }
            else if (pb3.Left >= this.Width - pb3.Width - 15)
            {
                timer1.Stop();
                MessageBox.Show("3.at kazandý!!!", "ÞAMPÝYON -3-");
            }
            else if (pb4.Left >= this.Width - pb4.Width - 15)
            {
                timer1.Stop();
                MessageBox.Show("4.at kazandý!!!", "ÞAMPÝYON -4-");
            }
        }
    }
}