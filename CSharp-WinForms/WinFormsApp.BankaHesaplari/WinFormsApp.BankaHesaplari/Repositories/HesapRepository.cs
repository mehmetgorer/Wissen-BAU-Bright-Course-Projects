using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.BankaHesaplari.Data;
using WinFormsApp.BankaHesaplari.Entities;
using WinFormsApp.BankaHesaplari.Interfaces;
using WinFormsApp.BankaHesaplari.Models;

namespace WinFormsApp.BankaHesaplari.Repositories
{
    public class HesapRepository : IHesapRepository
    {
        BankaDbContext _context = new BankaDbContext();
        public List<HesapModel> GetAllHesaplarWithMusteriler()
        {
            var liste = from h in _context.Hesaplar
                        join m in _context.Musteriler
                        on h.MusteriId equals m.Id
                        select new HesapModel
                        {
                            Id=h.Id,
                            HesapNo=h.HesapNo,
                            Tarih=h.Tarih,
                            Adi=m.Adi,
                            Soyadi=m.Soyadi,
                            TCKNo=m.TCKNo,
                            Telefon=m.Telefon,
                            Bakiye=h.Bakiye,
                            HesapTuru=h.HesapTuru,
                            MusteriId = h.MusteriId
                        };
            return liste.ToList();
        }
        public List<HesapModel> GetAllHesaplarWithMusterilerByAdaGore(string AdaGore)
        {
            var liste = from h in _context.Hesaplar
                        join m in _context.Musteriler
                        on h.MusteriId equals m.Id
                        where m.Adi.StartsWith(AdaGore)
                        select new HesapModel
                        {
                            Id = h.Id,
                            HesapNo = h.HesapNo,
                            Tarih = h.Tarih,
                            Adi = m.Adi,
                            Soyadi = m.Soyadi,
                            TCKNo = m.TCKNo,
                            Telefon = m.Telefon,
                            Bakiye = h.Bakiye,
                            HesapTuru = h.HesapTuru,
                            MusteriId = h.MusteriId
                        };
            return liste.ToList();
        }

        public List<HesapModel> GetAllHesaplarWithMusterilerByHesapTuru(string hesapTuru)
        {
            var liste = from h in _context.Hesaplar
                        join m in _context.Musteriler
                        on h.MusteriId equals m.Id
                        where h.HesapTuru == hesapTuru
                        select new HesapModel
                        {
                            Id = h.Id,
                            HesapNo = h.HesapNo,
                            Tarih = h.Tarih,
                            Adi = m.Adi,
                            Soyadi = m.Soyadi,
                            TCKNo = m.TCKNo,
                            Telefon = m.Telefon,
                            Bakiye = h.Bakiye,
                            HesapTuru = h.HesapTuru,
                            MusteriId = h.MusteriId
                        };
            return liste.ToList();
        }
        public void HesapEkle(Hesap h)
        {
            try
            {
                _context.Hesaplar.Add(h);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }

        }
        public string HesapNoOlustur()
        {
            return "ACC" + (_context.Hesaplar.Max(h => h.Id) + 1).ToString().PadLeft(4, '0');
        }
    }
}
