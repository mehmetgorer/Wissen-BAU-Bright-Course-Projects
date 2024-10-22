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



        public override string ToString()
        {
            return Name;
        }
    }
}
