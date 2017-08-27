using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juegdhuis_V3
{
    class KluisRepository
    {
        public KluisRepository()
        {
            var reader = new StreamReader(File.OpenRead("xml/Kluis.txt"));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] values = line.Split(':');
                if (values[0].Equals("dag"))
                {

                }
                if (values[0].Equals("reg"))
                {

                }
            }
        }
    }
}
