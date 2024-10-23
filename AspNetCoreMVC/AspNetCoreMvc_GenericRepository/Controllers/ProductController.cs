using AspNetCoreMvc_GenericRepository.Interfaces;
using AspNetCoreMvc_GenericRepository.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc_GenericRepository.Controllers
{
    public class ProductController : Controller
    {
        IGenericRepository<Product> _productRepo;

        public ProductController(IGenericRepository<Product> productRepo)
        {
            _productRepo = productRepo;
        }

        public IActionResult Index()
        {
            var urunler = _productRepo.GetAll().ToList();
            return View(urunler);
        }
    }
}
