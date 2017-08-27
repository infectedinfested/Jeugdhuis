using System;

namespace Juegdhuis_V3
{
    class Jhdag
    {
        public string naam1  { get; set; }
        public string naam2  { get; set; } 
        public string naam3  { get; set; }
        public DateTime datum  { get; set; }
        public string shift  { get; set; }
        public Jhdag(string naam1, string naam2, string naam3, DateTime datum, string shift)
        {
            this.naam1 = naam1;
            this.naam2 = naam2;
            this.naam3 = naam3;
            this.datum = datum;
            this.shift = shift;
        }
        public Jhdag(string invoer)
        {
            string[] splitted = invoer.Split(':');
            naam1 = splitted[0];
            naam2 = splitted[1];
            naam3 = splitted[2];
            datum = DateTime.Parse(splitted[3]);
            shift = splitted[4];

        }
        public string DatumToString()
        {
            return datum.Day + "/" + datum.Month + "/" + datum.Year; 
        }

        public Boolean equals(Jhdag invoer)
        {
            if (naam1.Equals(invoer.naam1))
            {
                if (naam2.Equals(invoer.naam2))
                {
                    if (naam3.Equals(invoer.naam3))
                    {
                        if (DatumToString().Equals(invoer.DatumToString()))
                        {
                            if (shift.Equals(invoer.shift))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        
    }
}
