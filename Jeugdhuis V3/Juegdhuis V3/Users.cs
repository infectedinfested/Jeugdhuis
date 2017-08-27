using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juegdhuis_V3
{
    class Users
    {
        public string naam { get; set; }
        public string passwoord { get; set; }
        public bool stock { get; set; }
        public string stockS { get; set; }
        public bool tapper { get; set; }
        public bool kluis { get; set; }
        public bool admin { get; set; }
        public string adminS { get; set; }

        public Users(string naam, string passwoord, bool stock,bool tapper,bool kluis,bool admin)
        {
            this.naam = naam;
            this.passwoord = passwoord;
            this.stock = stock;
            this.tapper = tapper;
            this.kluis = kluis;
            this.admin = admin;
            if (stock)
            {
                stockS = "ja";
            }else
            {
                stockS = "nee";
            }
            if (admin)
            {
                adminS = "ja";
            }
            else
            {
                adminS = "nee";
            }
        }
    }
}
