using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaktija
{
    public class SatnicaTxt
    {
        public string datum { get; set; }
        public string dan { get; set; }
        public string zora { get; set; }
        public string izlazak { get; set; }
        public string podne { get; set; }
        public string ikindija { get; set; }
        public string aksam { get; set; }
        public string jacija { get; set; }
    }

    public class Satnica
    {
        public DateTime datum { get; set; }
        public DateTime zora { get; set; }
        public DateTime izlazak { get; set; }
        public DateTime podne { get; set; }
        public DateTime ikindija { get; set; }
        public DateTime aksam { get; set; }
        public DateTime jacija { get; set; }
    }
}
