﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_EFCore
{
    public class Sinif
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return ClassName;
        }
    }
}
