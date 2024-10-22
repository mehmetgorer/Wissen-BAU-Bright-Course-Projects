using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.BankaHesaplari.Models
{
    public class HesapHareketModel
    {
        public int Id { get; set; }
        public string HesapNo { get; set; }
        public string Tarih { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public decimal Tutar { get; set; }
        public string IslemTuru { get; set; }
    }
}
