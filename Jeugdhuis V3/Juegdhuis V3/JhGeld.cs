using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juegdhuis_V3
{
    class JhGeld
    {
        public DateTime dag { get; set; }
        public double begingeld { get; set; }
        public string eindgeld { get; set; }
        public string winst { get; set; }

        public JhGeld(string v1, string v2, string v3)
        {
            dag = DateTime.ParseExact(v1, "d/M/yyyy", CultureInfo.InvariantCulture);
            begingeld = Double.Parse(v2);
            eindgeld = v3;
            try
            {
                double temp = Double.Parse(eindgeld) - begingeld;
                winst = temp+"";
            }
            catch (Exception)
            {
                winst = "/";
            }
            
        }
    }
}
