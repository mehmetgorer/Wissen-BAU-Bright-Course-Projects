using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Kalitim
{
    //OOP-3 Inheritance (Kalıtım-Miras Alma)
    //Canli -> Base class (temel alınan miras alınan class)
    //Bitki -> Derived class (base class'tan miras alan, türetilmiş class)
    public class Bitki : Canli  //Canli'nın özelliklerini miras alıyor.
    {

        private string _fotosentez;
        public string Fotosentez { get => _fotosentez; set => _fotosentez = value; }

        public override void Beslen()
        {
            
        }

        public override void SuIc()
        {
            
        }
    }
}
