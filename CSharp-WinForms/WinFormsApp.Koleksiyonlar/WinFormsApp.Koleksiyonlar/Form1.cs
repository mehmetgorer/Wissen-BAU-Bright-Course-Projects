using System.Collections;

namespace WinFormsApp.Koleksiyonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Klasik (Non-Generic) Koleksiyonlar
        //Array s�n�f�n� kullanan diziler IEnumerable s�n�f�n� uygulad�klar�ndan (implement) temel bir koleksiyon �rne�i say�l�rlar ve elemanlar�na foreach ile ula�abiliriz.
        //Dizilerin ayn� t�rden veri saklayabilmesi, boyutlar�n�n derleme a�amas�nda belirlenme zorunlulu�u, eleman say�lar�n�n art�r�lmas�ndaki sorunlar Collections s�n�f� alt�ndaki klasik koleksiyonlarla kolayl�kla a��labilir.
        //Klasik koleksiyonlara ArrayList, Queue, Stack, Hashtable, SortedList gibi �rnekler sayabiliriz. Verileri object olarak saklad�klar�ndan her t�rl� veri g�nderilebilir ve gelen veri say�s�na g�re boyutlar�n� kolayl�kla art�rabilirler.
        //Veriler koleksiyona eklenirken boxing yap�l�r, geri al�rken de unboxing i�lemi ger�ekle�ir, bu da performans� d���r�r.
        //Ayr�ca her t�rden veriyi kabul ettiklerinden veri g�venli�i tehlikeye girer. 

        ArrayList alist = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {
            alist.Add(1);   //Capacity -> 4     //int de�eri boxing ile object'e at�l�yor.
            alist.Add(2);
            alist.Add(3);
            alist.Add(4);
            alist.Add(5);   //Capacity x2 -> otomatik olarak 8'e ��kar.
            alist.Add(6);
            alist.Add(7);
            alist.Add(8);
            MessageBox.Show("Kapasite = " + alist.Capacity);
            foreach (int eleman in alist)  //int'e unboxing yap�l�r.
            {
                lbListe1.Items.Add(eleman);

            }
            //lbListe2.DataSource = alist;
            alist.Insert(5, 10);
            MessageBox.Show("Kapasite = " + alist.Capacity);
            MessageBox.Show("Eleman say�s� = " + alist.Count);
            for (int i = 0; i < alist.Count; i++)
            {
                lbListe2.Items.Add(alist[i]);
            }
            alist.Remove(4);  //koleksiyondan de�eri 4 olan eleman� siler.
            alist.RemoveAt(5); //koleksiyondan 5.s�radaki (indeksi 5 olan) eleman� siler.
                               //Silme i�lemlerinden sonra elemanlar ba�a do�ru kayd�r�l�r. Kapasite de�i�mez.
            foreach (int eleman in alist)  //int'e unboxing yap�l�r.
            {
                lbListe3.Items.Add(eleman);
            }
            //alist i�indeki say�lar�n toplam de�erini hesaplay�p g�steriniz.
            int toplam = 0;
            //foreach (object item in alist)
            //{
            //    toplam += Convert.ToInt32(item);  //unboxing
            //}
            for (int i = 0; i < alist.Count; i++)
            {
                toplam += Convert.ToInt32(alist[i]);  //(int)alist[i]
            }

            MessageBox.Show("Toplam : " + toplam);
        }
    }
}