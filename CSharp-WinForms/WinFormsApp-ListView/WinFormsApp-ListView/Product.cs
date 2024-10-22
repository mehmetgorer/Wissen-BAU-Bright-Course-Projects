using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_ListView
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public List<Product> GetAllProducts()
        {
            List<Product> Products = new List<Product>()
            {
                new(){Id=1, Name="Bilgisayar", Stock=5, Price=22500, Description="Oyun bilgisayarı"},
                new(){Id=2, Name="Yazıcı", Stock=15, Price=7500, Description="Laser yazıcı"},
                new(){Id=3, Name="Mouse", Stock=52, Price=500, Description="Kablosuz "},
                new(){Id=4, Name="Klavye", Stock=35, Price=800, Description="Mekanik klavye"}
            };
            return Products;
        }
    }
}
