using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AndroidMujezin.Modeli
{
    public class MjestoModel
    {
        public int MjestoIx { get; set; }
        public string MjestoNaziv { get; set; }
        
    }
    public class FajlaModel
    {
        public MjestoModel Mjesto { get; set; } 
        public int Godina { get; set; }
        public int Mjesec { get; set; }
        public string Path { get; set; }
    }
   
}
