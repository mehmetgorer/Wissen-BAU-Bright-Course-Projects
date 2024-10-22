using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.BankaHesaplari.Data;
using WinFormsApp.BankaHesaplari.Entities;
using WinFormsApp.BankaHesaplari.Interfaces;

namespace WinFormsApp.BankaHesaplari.Repositories
{
    public class MusteriRepository : IMusteriRepository
    {
        BankaDbContext _context = new BankaDbContext();
        public List<Musteri> GetAllMusteriler()
        {
            return _context.Musteriler.ToList();
        }
        public void MusteriEkle(Musteri m)
        {
            try
            {
                _context.Musteriler.Add(m);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
        }
        public void MusteriGuncelle(Musteri m)
        {
            _context.Musteriler.Update(m);
            _context.SaveChanges();
        }
        public void MusteriSil(Musteri m)
        {
            _context.Musteriler.Remove(m);
            _context.SaveChanges();
        }
    }
}
