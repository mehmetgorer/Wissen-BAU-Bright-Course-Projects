using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Kalitim
{
    public  class Hayvan : Canli
    {

        private string _hareket;
        public string Hareket { get => _hareket; set => _hareket = value; }

        public override void Beslen()
        {
            
        }
        public override void SuIc()
        {
            
        }
        public virtual string YeniDogan()
        {
            return "merhaba civciv";
        }
    }
}
