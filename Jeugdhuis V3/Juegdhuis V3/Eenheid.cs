using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juegdhuis_V3
{
    class Eenheid
    {
        public string eenheidC { get; set; }
        public string eenheidNC { get; set; }
        public int hoeveel { get; set; }
       
        public Eenheid(string eenheid, int hoeveelheid)
        {
            this.eenheidC = '€' + eenheid;
            this.hoeveel = hoeveelheid;
            this.eenheidNC = eenheid;
        }
    }
}
