using AspNetCoreMvc_GenericRepository.Interfaces;
using AspNetCoreMvc_GenericRepository.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc_GenericRepository.Controllers
{
    public class CategoryController : Controller
    {
        IGenericRepository<Category> _categoryRepo;

        public CategoryController(IGenericRepository<Category> categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public IActionResult Index()
        {
            //var kategori = _categoryRepo.GetById(2);
            var kategori = _categoryRepo.Get(c => c.Id == 2);
            return View();
        }
    }
}
