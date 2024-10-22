using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.BankaHesaplari.Data;
using WinFormsApp.BankaHesaplari.Entities;
using WinFormsApp.BankaHesaplari.Interfaces;
using WinFormsApp.BankaHesaplari.Models;

namespace WinFormsApp.BankaHesaplari.Repositories
{
    public class HesapHareketRepository : IHesapHareketRepository
    {
        BankaDbContext _context = new BankaDbContext();
        public List<HesapHareket> GetAllHareketler()
        {
            throw new NotImplementedException();
        }
        public List<HesapHareketModel> GetAllHareketlerWithHesapAndMusteriByHesapId(int hesapId)
        {
            var liste = from hh in _context.HesapHareketler
                        join m in _context.Musteriler
                        on hh.MusteriId equals m.Id
                        join h in _context.Hesaplar
                        on hh.HesapId equals h.Id
                        where hh.HesapId == hesapId
                        select new HesapHareketModel
                        {
                            Id = hh.Id,
                            HesapNo = h.HesapNo,
                            Tarih = hh.Tarih,
                            Adi = m.Adi,
                            Soyadi = m.Soyadi,
                            Tutar = hh.Tutar,
                            IslemTuru = hh.IslemTuru
                        };
            return liste.ToList();
        }
        public void HesapHareketEkle(HesapHareket hh)
        {
            _context.HesapHareketler.Add(hh);
            _context.SaveChanges();
        }
    }
}
