using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidMujezin.Modeli
{
    
        public class Dan
        {
            public List<string> vakat { get; set; }
        }

        public class Mjesec
        {
            public List<Dan> dan { get; set; }
        }

        public class VaktijaZaGodinu
        {
            public int id { get; set; }
            public string lokacija { get; set; }
            public int godina { get; set; }
            public List<Mjesec> mjesec { get; set; }
        }

        public class VaktijaZaMjesec
        {
            public int id { get; set; }
            public string lokacija { get; set; }
            public int godina { get; set; }
            public int mjesec { get; set; }
            public List<Dan> dan { get; set; }
        }


}

