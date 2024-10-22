using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.BankaHesaplari.Entities;
using WinFormsApp.BankaHesaplari.Models;

namespace WinFormsApp.BankaHesaplari.Interfaces
{
    public interface IHesapRepository
    {
        public string HesapNoOlustur();
        public List<HesapModel> GetAllHesaplarWithMusteriler();
        public List<HesapModel> GetAllHesaplarWithMusterilerByAdaGore(string AdaGore);
        public List<HesapModel> GetAllHesaplarWithMusterilerByHesapTuru(string hesapTuru);
        public void HesapEkle(Hesap h);
    }
}
