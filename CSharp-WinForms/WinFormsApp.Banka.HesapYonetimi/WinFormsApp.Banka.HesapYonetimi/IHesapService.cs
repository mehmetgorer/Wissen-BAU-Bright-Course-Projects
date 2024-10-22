using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Banka.HesapYonetimi
{
    public interface IHesapService
    {
        public int SonHesapIdBul();
        public string HesapNoOlustur(string Id);

        public void HesapAc(Hesap hesap);
        public List<Hesap> HesaplariGetir();
    }
}
