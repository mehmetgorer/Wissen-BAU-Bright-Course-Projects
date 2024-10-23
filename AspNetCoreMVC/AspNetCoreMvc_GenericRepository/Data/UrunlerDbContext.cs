using AspNetCoreMvc_GenericRepository.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMvc_GenericRepository.Data
{
    public class UrunlerDbContext : DbContext
    {
        public UrunlerDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
