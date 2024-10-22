namespace WinFormsApp_Generic_Collections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ornek<string> o1 = new Ornek<string>();
            o1.Ozellik1 = "Ali";

            Ornek<int> o2 = new Ornek<int>();
            o2.Ozellik1 = 20;

            MessageBox.Show(o1.Ozellik1 + ", " + o2.Ozellik1 + " yaþýnda");

            MessageBox.Show(o1.Metod("5"));
            MessageBox.Show(o2.Metod(5).ToString());  //Þablon metod ile normal metodun imzalarý ayný olduðunda, normal metod diðerine göre önceliklidir ve çalýþarak sayýnýn karesini döndürür.
        }
    }
}