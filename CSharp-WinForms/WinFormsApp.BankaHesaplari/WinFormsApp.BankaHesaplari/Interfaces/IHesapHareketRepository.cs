using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.BankaHesaplari.Entities;
using WinFormsApp.BankaHesaplari.Models;

namespace WinFormsApp.BankaHesaplari.Interfaces
{
    public interface IHesapHareketRepository
    {
        public List<HesapHareket> GetAllHareketler();
        public List<HesapHareketModel> GetAllHareketlerWithHesapAndMusteriByHesapId(int hesapId);
        public void HesapHareketEkle(HesapHareket hh);
    }
}
