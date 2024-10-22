using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Banka.HesapYonetimi
{
    public class HareketService : IHesapHareketService
    {
        List<HesapHareket> listeHareketler = new List<HesapHareket>()
        {
            new(){Id=1, HesapNo="ACC0001", Tarih="25.06.2023", Tutar=1000, IslemTuru="Yatan" },
            new(){Id=2, HesapNo="ACC0002", Tarih="25.06.2023", Tutar=2000, IslemTuru="Yatan" },
            new(){Id=3, HesapNo="ACC0003", Tarih="26.06.2023", Tutar=3000, IslemTuru="Yatan" }
        };
        public List<HesapHareket> HareketleriGetirByHesapNo(string hesapNo)
        {
            List<HesapHareket> liste = new List<HesapHareket>();
            foreach (HesapHareket hareket in listeHareketler)
            {
                if(hareket.HesapNo == hesapNo)
                {
                    liste.Add(hareket);
                }
            }
            return liste;
        }

        public void HesapHareketEkle(HesapHareket hareket)
        {
            listeHareketler.Add(hareket);
        }
    }
}
