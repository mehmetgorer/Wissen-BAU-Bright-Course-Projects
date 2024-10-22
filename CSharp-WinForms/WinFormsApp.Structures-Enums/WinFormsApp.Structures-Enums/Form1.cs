namespace WinFormsApp.Structures_Enums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Structures (yap�lar), class'lara �ok benzerler, ayn� class'larda oldu�u gibi members, properties ve constructors tan�mlayabiliriz. Ancak default constructor'a m�dahale edemiyoruz, parametreli yap�c� metotlar� istedi�imiz kadar tan�mlayabiliyoruz.
        //Class'lardan fark� Value Type olup stack haf�zada saklanmalar�d�r. Bu nedenle �m�rleri doldu�unda otomatik olarak haf�zadan at�l�rlar, yani takip edilmelerine gerek yoktur ve y�k�c� metotlar� bulunmamaktad�r.
        //Di�er �nemli fark da kal�t�m� (inheritance) desteklemezler.

        struct Ogrenci
        {
            #region Members
            private int _id;
            private string _name;
            private string _surname;
            #endregion

            #region Properties
            public int Id { get => _id; set => _id = value; }
            public string Name { get => _name; set => _name = value; }
            public string Surname { get => _surname; set => _surname = value; }
            #endregion

            #region Methods
            public void OgrenciKaydet(int id, string ad, string soyad)
            {
                //��renci veritaban�na kay�t edilir.
            } 
            #endregion

            #region Yap�c� Metod (constructor)
            public Ogrenci(int id, string ad, string soyad)
            {
                _id = id;
                _name = ad;
                _surname = soyad;
            } 
            #endregion
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Id = 1;
            ogrenci.Name = "Ali";
            ogrenci.Surname = "U�ar";
            MessageBox.Show(ogrenci.Id + " nolu ��renci, " + ogrenci.Name + " " + ogrenci.Surname);

            Ogrenci ogr = new Ogrenci(2, "Oya", "Sever");
            MessageBox.Show(ogr.Id + " nolu ��renci, " + ogr.Name + " " + ogr.Surname);
        }
    }
}