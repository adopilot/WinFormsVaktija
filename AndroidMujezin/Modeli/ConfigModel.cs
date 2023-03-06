using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AndroidMujezin.Modeli
{
    public class ConfigModel
    {
        public bool EzaniZora { get; set; } = false;
        public bool EzaniIzlazak { get; set; } = true;
        public bool EzaniPodne { get; set; } = true;
        public bool EzaniInindija { get; set; } = true;
        public bool EzaniAksam { get; set; } = true;
        public bool EzaniJaciju { get; set; } = true;

        public string EzanZora { get; set; } = "ezan.mp3";
        public string EzanIzlazak { get; set; } = "ezan.mp3";
        public string EzanPodne { get; set; } = "ezan.mp3";
        public string EzanInindija { get; set; } = "ezan.mp3";
        public string EzanAksam { get; set; } = "ezan.mp3";
        public string EzanJaciju { get; set; } = "ezan.mp3";
        public bool PodneVazdaU12 { get; set; } = false;
        public bool DjumaVazaU12 { get; set; } = true;

        public int KorekcijaZora { get; set; } = 10;
        public int KorekcijaIzlazak { get; set; } = 30;

        public double EzanZoraVol { get; set; } = 100;
        public double EzanIzlazakVol { get; set; } = 100;
        public double EzanPodneVol { get; set; } = 100;
        public double EzanInindijaVol { get; set; } = 100;
        public double EzanAksamVol { get; set; } = 100;
        public double EzanJacijuVol { get; set; } = 100;

        public string Baza { get;  set; }

        public List<string> Baze { get; set; }
    }
}
