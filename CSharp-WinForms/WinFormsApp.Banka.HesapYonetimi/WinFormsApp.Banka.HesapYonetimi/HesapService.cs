using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Banka.HesapYonetimi
{
    public class HesapService : IHesapService
    {
        List<Hesap> listeHesaplar = new List<Hesap>()
        {
            new(){Id=1, HesapNo="ACC0001", Tarih="25.06.2023", MusteriAdi="Ali", MusteriSoyadi="Uçar", TCKimlikNo="35352345234", Bakiye=1000, HesapTuru="VadesizHesap" },
            new(){Id=2, HesapNo="ACC0002", Tarih="25.06.2023", MusteriAdi="Ayşe", MusteriSoyadi="Koşar", TCKimlikNo="35352349876", Bakiye=2000, HesapTuru="VadesizHesap" },
            new(){Id=3, HesapNo="ACC0003", Tarih="26.06.2023", MusteriAdi="Oya", MusteriSoyadi="Sever", TCKimlikNo="12321345234", Bakiye=3000, HesapTuru="VadesizHesap" }
        };
        public void HesapAc(Hesap hesap)
        {
            listeHesaplar.Add(hesap);
        }

        public List<Hesap> HesaplariGetir()
        {
            return listeHesaplar;
        }

        public string HesapNoOlustur(string Id)
        {
            return "ACC" + Id.PadLeft(4, '0');
        }

        public int SonHesapIdBul()
        {
            return listeHesaplar.Last().Id + 1;
        }
    }
}
