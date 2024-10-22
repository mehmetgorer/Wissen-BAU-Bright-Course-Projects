using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.BankaHesaplari.Entities;

namespace WinFormsApp.BankaHesaplari.Interfaces
{
    public interface IMusteriRepository
    {
        public List<Musteri> GetAllMusteriler();
        public void MusteriEkle(Musteri m);
        public void MusteriGuncelle(Musteri m);
        public void MusteriSil(Musteri m);

    }
}
