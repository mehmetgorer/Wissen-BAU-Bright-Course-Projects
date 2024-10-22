using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.BankaHesaplari.Entities
{
    public class Hesap
    {
        public int Id { get; set; }
        public string HesapNo { get; set; }
        public string Tarih { get; set; }
        public int MusteriId { get; set; }
        public decimal Bakiye { get; set; }
        public string HesapTuru { get; set; }
    }
}
