namespace WinFormsApp.Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Diziler, hafýzada ardarda yerleþen, ayný türde ve ayný isimle çaðrýlabilen nesneler topluluðudur. System.Array sýnýfýn özelliklerini ve metotlarýný kullanýrlar. Tek bir isim kullanýldýðýndan herbir elemana eriþmek için indeks kullanýlýr. Ýndeksler 0'dan baþlar.

        int[] sayilar = new int[5];
        string[] takimlar = { "Fenerbahçe", "Galatasaray", "Beþiktaþ", "Bursa", "Trabzon" };    //string[5] olarak tanýmlayýp içine deðerlerini otomatik olarak yerleþtiriyor.
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(sayilar[0].ToString());  //new ile tanýmladýðýmýzdan tüm elemanlara varsayýlan (default) deðer olarak 0 (sýfýr) atanýyor.
            sayilar[0] = 12;    //Dizinin ilk elemanýna 12 deðeri atandý.
            sayilar[1] = 14;    //Dizinin ikinci elemanýna (indeksi 1 olan) 15 deðerini atadýk.
            sayilar[2] = 16;
            sayilar[3] = 18;
            sayilar[4] = 20;    //sayilar dizisinin son elemaný.
                                //sayilar[5] = 30;    //dizinin indeks sayýlarýndan daha büyük deðer verildiðinde derleyici hata (out of range) verir.
                                //MessageBox.Show("Dizinin eleman sayýsý = " + sayilar.Length);
                                //MessageBox.Show(sayilar[sayilar.Length - 1].ToString()); //Dizinin son elemanýnýn deðerini gösterir.
                                //MessageBox.Show(sayilar[5].ToString());

            //foreach (int i in sayilar)
            //{
            //    MessageBox.Show(i.ToString());
            //}

            //IEnumerable sýnýfýndan türetilmiþ tüm koleksiyon yapýlarý içinde foreach döngüleriyle dolaþarak, sýrayla deðerlere eriþebiliriz, ancak üzerlerinde deðiþiklik yapamayýz.

            //foreach (string takim in takimlar)
            //{
            //    MessageBox.Show(takim);
            //}

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    MessageBox.Show(sayilar[i].ToString());
            //}
            //for (int i = 0; i < takimlar.Length; i++)
            //{
            //    MessageBox.Show(takimlar[i]);
            //}

            lbTakimlar.Items.Add("Ýstanbulspor");

            lbTakimlar.Items.Clear();  //Listbox'ýn elemanlarýný silerek listeyi temizler.

            //foreach (string takim in takimlar)
            //{
            //    lbTakimlar.Items.Add(takim);
            //}

            lbTakimlar.Items.AddRange(takimlar); //Dizinin (koleksiyonun) tüm elemanlarýný listbox'a ekler.
        }
    }
}