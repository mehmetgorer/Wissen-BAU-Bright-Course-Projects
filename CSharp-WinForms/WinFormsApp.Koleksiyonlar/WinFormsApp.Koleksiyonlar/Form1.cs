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
        //Array sýnýfýný kullanan diziler IEnumerable sýnýfýný uyguladýklarýndan (implement) temel bir koleksiyon örneði sayýlýrlar ve elemanlarýna foreach ile ulaþabiliriz.
        //Dizilerin ayný türden veri saklayabilmesi, boyutlarýnýn derleme aþamasýnda belirlenme zorunluluðu, eleman sayýlarýnýn artýrýlmasýndaki sorunlar Collections sýnýfý altýndaki klasik koleksiyonlarla kolaylýkla aþýlabilir.
        //Klasik koleksiyonlara ArrayList, Queue, Stack, Hashtable, SortedList gibi örnekler sayabiliriz. Verileri object olarak sakladýklarýndan her türlü veri gönderilebilir ve gelen veri sayýsýna göre boyutlarýný kolaylýkla artýrabilirler.
        //Veriler koleksiyona eklenirken boxing yapýlýr, geri alýrken de unboxing iþlemi gerçekleþir, bu da performansý düþürür.
        //Ayrýca her türden veriyi kabul ettiklerinden veri güvenliði tehlikeye girer. 

        ArrayList alist = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {
            alist.Add(1);   //Capacity -> 4     //int deðeri boxing ile object'e atýlýyor.
            alist.Add(2);
            alist.Add(3);
            alist.Add(4);
            alist.Add(5);   //Capacity x2 -> otomatik olarak 8'e çýkar.
            alist.Add(6);
            alist.Add(7);
            alist.Add(8);
            MessageBox.Show("Kapasite = " + alist.Capacity);
            foreach (int eleman in alist)  //int'e unboxing yapýlýr.
            {
                lbListe1.Items.Add(eleman);

            }
            //lbListe2.DataSource = alist;
            alist.Insert(5, 10);
            MessageBox.Show("Kapasite = " + alist.Capacity);
            MessageBox.Show("Eleman sayýsý = " + alist.Count);
            for (int i = 0; i < alist.Count; i++)
            {
                lbListe2.Items.Add(alist[i]);
            }
            alist.Remove(4);  //koleksiyondan deðeri 4 olan elemaný siler.
            alist.RemoveAt(5); //koleksiyondan 5.sýradaki (indeksi 5 olan) elemaný siler.
                               //Silme iþlemlerinden sonra elemanlar baþa doðru kaydýrýlýr. Kapasite deðiþmez.
            foreach (int eleman in alist)  //int'e unboxing yapýlýr.
            {
                lbListe3.Items.Add(eleman);
            }
            //alist içindeki sayýlarýn toplam deðerini hesaplayýp gösteriniz.
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