using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_LinqToObject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            List<Ogrenci> list = new List<Ogrenci>() {
                new(){Id=1, Ad="Ali", Soyad="Uçar", Adres="İnönü Mah. Sefaköy", Sehir="İstanbul", Yas=28},
                new(){Id=2, Ad="Hakan", Soyad="Coşar", Adres="Altıyol Kadıköy", Sehir="İstanbul", Yas=24},
                new(){Id=3, Ad="Zeynep", Soyad="Sever", Adres="Rıhtım Cad. Göztepe", Sehir="İzmir", Yas=18},
                };
            Ogrenci ogr = new Ogrenci();
            ogr.Id = 4;
            ogr.Ad = "Ayşe";
            ogr.Soyad = "Koşar";
            ogr.Adres = "1. Kordon Konak";
            ogr.Sehir = "İzmir";
            ogr.Yas = 32;
            list.Add(ogr);

            Ogrenci ogr2 = new Ogrenci();
            ogr2.Id = 5;
            ogr2.Ad = "Oya";
            ogr2.Soyad = "Kayalı";
            ogr2.Adres = "Bakanlıklar Cad. Bahçelievler";
            ogr2.Sehir = "Ankara";
            ogr2.Yas = 22;
            list.Add(ogr2);

            foreach (Ogrenci o in list)
            {
                lbListe.Items.Add(o.Ad + " " + o.Soyad);
                lbListe.Items.Add(o.Adres + " " + o.Sehir);
                lbListe.Items.Add("Yaşı = " + o.Yas);
            }

            //select * from Ogrenciler
            //var Sonuc = from o in list
            //            select o;

            //İstanbul'da oturan öğrencilerin listesi.
            //select * from Ogrenciler where Sehir='İstanbul'
            //var Sonuc = from o in list
            //            where o.Sehir == "İstanbul"
            //            select o;

            //İstanbul'da yada Ankara'da oturan öğrencilerin listesi.
            //select * from Ogrenciler where Sehir='İstanbul' or Sehir='Ankara'
            //var Sonuc = from o in list
            //            where o.Sehir == "İstanbul" || o.Sehir == "Ankara"
            //            select o;
            //var Sonuc = list.Where(o => o.Sehir == "İstanbul" || o.Sehir == "Ankara");

            //İsmi A ile başlayan öğrencilerin listesi
            //select * from Ogrenciler where Ad like 'A%'
            //var Sonuc = from o in list
            //            where o.Ad.StartsWith("A")
            //            select o;

            //İsminin içinde a harfi geçen öğrencilerin listesi.
            //select * from Ogrenciler where Ad like '%a%'
            //var Sonuc = from o in list
            //            where o.Ad.Contains("a")
            //            select o;
            //var Sonuc = from o in list
            //            where o.Ad.ToLower().Contains("a")
            //            select o;

            //Yaşı 20-30 aralığında olan öğrencilerin listesi.
            //select * from Ogrenciler where Yas between 20 and 30
            //select * from Ogrenciler where Yas >= 20 and Yas <= 30
            //var Sonuc = from o in list
            //            where o.Yas >= 20 && o.Yas <= 30
            //            select o;

            //Yaşı 20-30 aralığında olan öğrencilerin sayısı.
            //select count(*) from Ogrenciler where Yas >= 20 and Yas <= 30
            //var Sonuc = (from o in list
            //            where o.Yas >= 20 && o.Yas <= 30
            //            select o).Count();
            //int Sonuc = list.Where(o => o.Yas >= 20 && o.Yas <= 30).Count(); 
            //MessageBox.Show("20-30 arasındakilerin sayısı = " + Sonuc);

            //Yaşı 20-30 aralığında olan öğrencilerin yaş ortalaması.
            //select avg(Yas) from Ogrenciler where Yas >= 20 and Yas <= 30
            //var Sonuc = (from o in list
            //             where o.Yas >= 20 && o.Yas <= 30
            //             select o).Average(o => o.Yas);

            //var Sonuc = (from o in list
            //             where o.Yas >= 20 && o.Yas <= 30
            //             select o.Yas).Average();
            //var Sonuc = list.Where(o => o.Yas >= 20 && o.Yas <= 30).Select(o => o.Yas).Average();
            //MessageBox.Show("20-30 arasındakilerin yaş ortalaması = " + Sonuc);

            //Öğrencilerimizin kaç farklı şehirden geldiğini gösteren sorgu.
            //select count(distinct Sehir) from Ogrenciler
            //var Sonuc = (from o in list
            //             select o.Sehir).Distinct().Count();

            //MessageBox.Show("Farklı şehir sayısı = " + Sonuc);

            //var Sonuc = from o in list  //var -> List<string>
            //select o.Ad;

            //var Sonuc = from o in list
            //            select new { o.Ad, o.Soyad, o.Yas };

            //foreach (var o in Sonuc)
            //{
            //    lbSonuc.Items.Add(o.Ad + " " + o.Soyad);
            //    lbSonuc.Items.Add("Yaşı = " + o.Yas);
            //}

            //var Sonuc = from o in list
            //            select new Yeni { Name = o.Ad, Surname = o.Soyad, Age = o.Yas };

            //foreach (Yeni o in Sonuc)
            //{
            //    lbSonuc.Items.Add(o.Name + " " + o.Surname);
            //    lbSonuc.Items.Add("Yaşı = " + o.Age);
            //}

            //Select Sehir, count(*) from Ogrenciler group by Sehir
            //var Gruplar = from o in list
            //              group o by o.Sehir into bySehir
            //              select bySehir;

            //foreach (var grup in Gruplar)       //Key -> Sehir
            //{
            //    MessageBox.Show("Grubu oluşturan kolon : " + grup.Key + ", grubun eleman sayısı : " + grup.Count());
            //}

            var Gruplar = from o in list
                          group o by o.Sehir into bySehir
                          select new
                          {
                              ili = bySehir.Key,
                              sayisi = bySehir.Count(),
                              ogrenciler = bySehir
                          };

            foreach (var grup in Gruplar)
            {
                MessageBox.Show("Grup ismi : " + grup.ili + ", eleman sayısı : " + grup.sayisi);
                foreach (var o in grup.ogrenciler)
                {
                    MessageBox.Show(o.Ad + ", " + o.Soyad);
                }
            }

            //foreach (Ogrenci o in Sonuc)
            //{
            //    lbSonuc.Items.Add(o.Ad + " " + o.Soyad);
            //    lbSonuc.Items.Add(o.Adres + " " + o.Sehir);
            //    lbSonuc.Items.Add("Yaşı = " + o.Yas);
            //}

        }
    }
    public class Yeni
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
