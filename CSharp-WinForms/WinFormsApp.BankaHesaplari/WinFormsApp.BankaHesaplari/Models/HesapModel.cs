using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.BankaHesaplari.Models
{
    public class HesapModel
    {
        public int Id { get; set; }
        public string HesapNo { get; set; }
        public string Tarih { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TCKNo { get; set; }
        public string Telefon { get; set; }
        public decimal Bakiye { get; set; }
        public string HesapTuru { get; set; }
        public int MusteriId { get; set; }
    }
}
