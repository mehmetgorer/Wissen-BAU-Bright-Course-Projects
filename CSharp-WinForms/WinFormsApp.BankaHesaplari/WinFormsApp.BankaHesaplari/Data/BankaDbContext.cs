using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.BankaHesaplari.Entities;

namespace WinFormsApp.BankaHesaplari.Data
{
    public class BankaDbContext : DbContext
    {
        public DbSet<Hesap> Hesaplar { get; set; }
        public DbSet<HesapHareket> HesapHareketler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-Q99D8J1\\MSSQL2019;Initial Catalog=BankaHesaplari;User ID=sa;Password=54321; TrustServerCertificate=true");
        }


    }
}
