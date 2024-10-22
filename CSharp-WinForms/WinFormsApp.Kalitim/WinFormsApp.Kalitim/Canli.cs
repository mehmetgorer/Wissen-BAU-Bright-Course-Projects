using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Kalitim
{
    public abstract class Canli
    {
        #region Members
        private string _solunum;
        private string _beslenme;
        private string _bosaltim;
        private string _ureme;
        #endregion

        #region Properties
        public string Solunum { get => _solunum; set => _solunum = value; }
        public string Beslenme { get => _beslenme; set => _beslenme = value; }
        public string Bosaltim { get => _bosaltim; set => _bosaltim = value; }
        public string Ureme { get => _ureme; set => _ureme = value; }
        #endregion

        //Abstract metodlar abstract class'larda tanımlanabilir. Gövdeleri olmayan, miras alan türetilmiş class'lar tarafından kullanılmak zorunda olan metodlardır.
        //abstract metodlar otomatik olarak virtual kabul edilir, türetilen class'larda ezilip değiştirilebilir (override).
        public abstract void Beslen();

        public abstract void SuIc();

    }
}
