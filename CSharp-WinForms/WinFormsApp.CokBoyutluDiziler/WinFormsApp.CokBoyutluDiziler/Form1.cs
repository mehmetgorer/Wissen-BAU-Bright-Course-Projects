namespace WinFormsApp.CokBoyutluDiziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Dimension - boyut
            int[] sayilar = { 1, 2, 3, 4 };
            //int[,] notlar = new int[5, 2];
            string[] ogrenciler = { "Sedat", "Vedat", "Sezgin", "Gülay", "Oya" };
            int[,] notlar = { { 30, 50 }, { 50, 70 }, { 60, 40 }, { 80, 40 }, { 90, 70 } };

            //MessageBox.Show(sayilar[0].ToString());
            //MessageBox.Show(notlar[0, 0].ToString()); //dizinin ilk elemaný
            //MessageBox.Show("Eleman sayýsý = " + notlar.Length);
            //MessageBox.Show("Satýr sayýsý = " + notlar.GetLength(0));
            //MessageBox.Show("Sütun sayýsý = " + notlar.GetLength(1));

            for (int i = 0; i < notlar.GetLength(0); i++)
            {
                for (int j = 0; j < notlar.GetLength(1); j++)
                {
                    MessageBox.Show(notlar[i, j].ToString());
                }
            }
        }
    }
}