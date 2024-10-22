namespace WinFormsApp.Structures_Enums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Structures (yapýlar), class'lara çok benzerler, ayný class'larda olduðu gibi members, properties ve constructors tanýmlayabiliriz. Ancak default constructor'a müdahale edemiyoruz, parametreli yapýcý metotlarý istediðimiz kadar tanýmlayabiliyoruz.
        //Class'lardan farký Value Type olup stack hafýzada saklanmalarýdýr. Bu nedenle ömürleri dolduðunda otomatik olarak hafýzadan atýlýrlar, yani takip edilmelerine gerek yoktur ve yýkýcý metotlarý bulunmamaktadýr.
        //Diðer önemli fark da kalýtýmý (inheritance) desteklemezler.

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
                //Öðrenci veritabanýna kayýt edilir.
            } 
            #endregion

            #region Yapýcý Metod (constructor)
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
            ogrenci.Surname = "Uçar";
            MessageBox.Show(ogrenci.Id + " nolu öðrenci, " + ogrenci.Name + " " + ogrenci.Surname);

            Ogrenci ogr = new Ogrenci(2, "Oya", "Sever");
            MessageBox.Show(ogr.Id + " nolu öðrenci, " + ogr.Name + " " + ogr.Surname);
        }
    }
}