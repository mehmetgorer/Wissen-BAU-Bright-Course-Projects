using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.BankaHesaplari.Entities
{
    public class HesapHareket
    {
        public int Id { get; set; }
        public string Tarih { get; set; }
        public int HesapId { get; set; }
        public int MusteriId { get; set; }
        public decimal Tutar { get; set; }
        public string IslemTuru { get; set; }
    }
}
