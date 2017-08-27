using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juegdhuis_V3
{
    class Drank
    {
        public string naam { get; set; }
        public int hoeveel { get; set; }
        public double prijs { get; set; }
        public string sPrijs { get; set; }
        public string voldoende { get; set; }

        public Drank(string naam, int hoeveelheid, double prijs)
        {
            this.naam = naam;
            this.hoeveel = hoeveelheid;
            this.prijs = prijs;
            var temp = Convert.ToString(prijs);
            var temp2 = '€'+temp;
            this.sPrijs = temp2;
            this.voldoende = berekenVoldoende(naam, hoeveelheid);
        }
        private string berekenVoldoende(string naam, int hoeveelheid)
        {
            return "ja";
        }
    }
}
