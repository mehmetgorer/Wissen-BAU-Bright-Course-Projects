using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Kalitim
{
    public sealed class Insan : Hayvan
    {
        private string _dusunur;
        public string Dusunur { get => _dusunur; set => _dusunur = value; }

        //YeniDogan metodu Hayvan class'ında virtual tanımlandığı için. miras alan yani türetilen Insan class'ında override edilebilir.
        public override string YeniDogan()
        {
            return "merhaba bebek";
        }
    }
}
