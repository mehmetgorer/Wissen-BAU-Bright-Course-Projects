using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Banka.HesapYonetimi
{
    public class Hesap
    {
        public int Id { get; set; }
        public string HesapNo { get; set; }
        public string Tarih { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string TCKimlikNo { get; set; }
        public double Bakiye { get; set; }
        public string HesapTuru { get; set; }
    }
}
