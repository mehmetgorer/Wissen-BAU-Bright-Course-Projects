namespace WinFormsApp.Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Diziler, haf�zada ardarda yerle�en, ayn� t�rde ve ayn� isimle �a�r�labilen nesneler toplulu�udur. System.Array s�n�f�n �zelliklerini ve metotlar�n� kullan�rlar. Tek bir isim kullan�ld���ndan herbir elemana eri�mek i�in indeks kullan�l�r. �ndeksler 0'dan ba�lar.

        int[] sayilar = new int[5];
        string[] takimlar = { "Fenerbah�e", "Galatasaray", "Be�ikta�", "Bursa", "Trabzon" };    //string[5] olarak tan�mlay�p i�ine de�erlerini otomatik olarak yerle�tiriyor.
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(sayilar[0].ToString());  //new ile tan�mlad���m�zdan t�m elemanlara varsay�lan (default) de�er olarak 0 (s�f�r) atan�yor.
            sayilar[0] = 12;    //Dizinin ilk eleman�na 12 de�eri atand�.
            sayilar[1] = 14;    //Dizinin ikinci eleman�na (indeksi 1 olan) 15 de�erini atad�k.
            sayilar[2] = 16;
            sayilar[3] = 18;
            sayilar[4] = 20;    //sayilar dizisinin son eleman�.
                                //sayilar[5] = 30;    //dizinin indeks say�lar�ndan daha b�y�k de�er verildi�inde derleyici hata (out of range) verir.
                                //MessageBox.Show("Dizinin eleman say�s� = " + sayilar.Length);
                                //MessageBox.Show(sayilar[sayilar.Length - 1].ToString()); //Dizinin son eleman�n�n de�erini g�sterir.
                                //MessageBox.Show(sayilar[5].ToString());

            //foreach (int i in sayilar)
            //{
            //    MessageBox.Show(i.ToString());
            //}

            //IEnumerable s�n�f�ndan t�retilmi� t�m koleksiyon yap�lar� i�inde foreach d�ng�leriyle dola�arak, s�rayla de�erlere eri�ebiliriz, ancak �zerlerinde de�i�iklik yapamay�z.

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

            lbTakimlar.Items.Add("�stanbulspor");

            lbTakimlar.Items.Clear();  //Listbox'�n elemanlar�n� silerek listeyi temizler.

            //foreach (string takim in takimlar)
            //{
            //    lbTakimlar.Items.Add(takim);
            //}

            lbTakimlar.Items.AddRange(takimlar); //Dizinin (koleksiyonun) t�m elemanlar�n� listbox'a ekler.
        }
    }
}