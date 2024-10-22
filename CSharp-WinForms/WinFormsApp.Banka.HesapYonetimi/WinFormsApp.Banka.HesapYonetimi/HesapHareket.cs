using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Banka.HesapYonetimi
{
    public class HesapHareket
    {
        public int Id { get; set; }
        public string HesapNo { get; set; }
        public string Tarih { get; set; }
        public double Tutar { get; set; }
        public string IslemTuru { get; set; }


    }
}
