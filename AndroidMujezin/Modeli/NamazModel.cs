using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidMujezin.Modeli
{

    public class NamazConfigModel
    {
        public NamazModel Zora { get; set; } = new NamazModel() { Namaz= NamazEnum.Zora};
        public NamazModel IzlazakSunca { get; set; } = new NamazModel() { Namaz = NamazEnum.IzlazakSunca };
        public NamazModel Podne { get; set; } = new NamazModel() { Namaz = NamazEnum.Podne };
        public NamazModel Ikindija { get; set; } = new NamazModel() { Namaz = NamazEnum.Ikindija };
        public NamazModel Aksam { get; set; } = new NamazModel() { Namaz = NamazEnum.Aksam };
        public NamazModel Jacija { get; set; } = new NamazModel() { Namaz = NamazEnum.Jacija };
        public NamazModel Dzuma { get; set; } = new NamazModel() { Namaz = NamazEnum.Dzuma };


    }

    public class NamazModel
    {
        public NamazEnum Namaz { get; set; }
        public bool? Ezani { get; set; }
        public int KorekcijaMinta { get; set; }
        public bool U12 { get; set; }
        public bool? Notifikuj { get; set; }
        public int NotifikujMinutaPrije { get; set; }
        public int Volume { get; set; } = 100;
        public string FajlaZaEzan { get; set; }
        public DateTime Satnica { get; set; }

    }
    public enum NamazEnum
    {
        Zora,
        IzlazakSunca,
        Podne,
        Ikindija,
        Aksam,
        Jacija,
        Dzuma

    }
}
