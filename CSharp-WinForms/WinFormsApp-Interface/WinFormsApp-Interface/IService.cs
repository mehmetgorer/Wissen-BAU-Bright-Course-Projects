using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_Interface
{
    //Interface (Arayüz), class'lara rehberlik ederler, yön verirler.
    //Abstract (Soyut) class'lara çok benzerler. Yani metodlar otomatik olarak virtual kabul edilir, miras alan class'lar tarafından uygulanmaları (implement) zorunludur.
    //Sadece bir class'dan miras alınabilirken, birden fazla interface implement edilebilir (uygulanabilir).
    //İsimlendirilirken best practice olarak ilk harf olarak I harfi kullanılır.
    public interface IService
    {
        public List<Product> GetProducts();

        public Product GetProductById(int id);

        public string GetProductName(int id);

        public void AddProduct(Product product);
    }
}
