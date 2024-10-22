using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_EFCore
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public string TCKNo { get; set; }
        public int ClassId { get; set; }

        OkulContext _context = new OkulContext();

        public void Add(Ogrenci ogr)
        {
            _context.Ogrenciler.Add(ogr);   //yeni öğrenciyi ara katmana ekler
            _context.SaveChanges();
        }
        public List<Ogrenci> GetAllOgrencilerBySinif(int SinifId)
        {
            return _context.Ogrenciler.Where(o => o.ClassId == SinifId).ToList();
        }
        public void Update(Ogrenci o)
        {
            _context.Ogrenciler.Update(o);
            _context.SaveChanges();
        }
        public void Delete(Ogrenci o)
        {
            _context.Ogrenciler.Remove(o);
            _context.SaveChanges();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
