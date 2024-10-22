using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Banka.HesapYonetimi
{
    public interface IHesapHareketService
    {
        public void HesapHareketEkle(HesapHareket hareket);
        public List<HesapHareket> HareketleriGetirByHesapNo(string hesapNo);
    }
}
