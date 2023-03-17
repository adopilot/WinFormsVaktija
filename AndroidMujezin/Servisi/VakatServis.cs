using AndroidMujezin.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidMujezin.Servisi
{
    public class VakatServis
    {
        public VakatServis() { }    
        public string NazivNamazaNominativ(NamazEnum namazEnum)
        {
            switch(namazEnum)
            {
                case NamazEnum.IzlazakSunca:
                    return "Izlazak sunca";
                    
                case NamazEnum.Zora:
                    return "Zora (sabah)";
                case NamazEnum.Podne:
                    return "Podne";
                case NamazEnum.Ikindija:
                    return "Ikindija";
                case NamazEnum.Aksam:
                    return "Akšam";
                case NamazEnum.Jacija:
                    return "Jacija";
                case NamazEnum.Dzuma:
                    return "Džuma";
                default:
                    return $"Neznam za ovaj namaz {namazEnum}";
            };
            
        }
    }
}
