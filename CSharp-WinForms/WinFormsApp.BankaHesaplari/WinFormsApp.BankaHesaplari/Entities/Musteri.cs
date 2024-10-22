using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.BankaHesaplari.Entities
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TCKNo { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }

        public override string ToString()
        {
            return Adi + " " + Soyadi;
        }

    }
}
