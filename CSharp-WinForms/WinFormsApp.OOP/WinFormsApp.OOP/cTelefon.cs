using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WinFormsApp.OOP
{
    public class cTelefon
    {
        #region Members
        private string _marka;
        private string _model;
        private string _islemci;
        private float _ekran;
        private string _renk;
        private double _fiyat;
        private double _hafiza;
        private float _agirlik;
        #endregion

        //private üye elemanlarımızın public property'lerle sarmallanarak koruma altına alınmasına, istediğimiz zaman property'lere müdahale şansımızın olmasına, OOP-2 SARMALLAMA-ENCAPSULATION prensibi denir.

        #region Properties
        public string Marka
        {
            get
            {
                return _marka;
            }
            set
            {
                _marka = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        public string Model { get => _model; set => _model = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower(); }
        public string Islemci { get => _islemci; set => _islemci = value; }
        public float Ekran { get => _ekran; set => _ekran = value; }
        public string Renk { get => _renk; set => _renk = value; }
        public double Fiyat { get => _fiyat; set => _fiyat = value; }
        public double Hafiza { get => _hafiza; set => _hafiza = value; }
        public float Agirlik { get => _agirlik; set => _agirlik = value; }
        #endregion

        //public int Adi { get; set; }
        //public int Soyadi { get; set; }

        public string AramaYap(string telno)
        {
            return telno + " aranıyor...";
            //MessageBox.Show(telno + " aranıyor...");
        }
        public string SmsGonder(string telno, string mesaj)
        {
            return telno + " numaralı telefona \"" + mesaj + " \" mesajı gönderiliyor.";
        }

        //Constructors (Yapıcı Metotlar) : Biz yazmasak bile her class'ın varsayılan (default) boş bir yapıcı metodu vardır. New ile nesne oluştururken ilk olarak yapıcı metotlar otomatik olarak çalıştırılır.
        //Biz istediğimiz kadar parametreli yapıcı metot tanımlayabiliriz. Ancak biz tanımladığımızda default constructor devre dışı kalır.
        //İsmi class ile aynı, geriye değer döndürmüyor ancak void kullanmıyoruz.

        //Destructure (Yıkıcı Metod) : Yalnızca 1 tane tanımlanabilir. Class ile aynı isimdedir. İsmin başına ~ (tilda) getirilir. Parametre almaz, geriye değer döndürmez, başında erişim belirleyici kullanılmaz.

        //New ile oluşan ve hafızada yaşamaya devam eden nesneler (objects) Gereksiz Nesne Toplayıcı (Garbage Collector) tarafından takip edilir,  kullanılmadığına karar verildiğinde hafızadan atılır. Garbage Collector'un ne zaman devreye gireceğini bilmememize rağmen, nesneler hafızadan atılmadan önce Yıkıcı metoda uğradığını biliyoruz.

        public cTelefon(string marka, string model)
        {
            _marka = marka;
            _model = model;
        }

        public cTelefon() { }   //Kendimiz default constructor tanımlıyoruz.

        ~cTelefon()
        {
            MessageBox.Show("cTelefon nesnesi hafızadan atılıyor.");
        }
    }
}
