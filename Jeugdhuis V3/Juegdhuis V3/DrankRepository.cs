
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;


namespace Juegdhuis_V3
{
    class DrankRepository
    {
        public List<Drank> dranken = new List<Drank>();
        public void ImportDrank()
        {
            dranken.Clear();
            List<string> temp1 = new List<string>(); //naam
            List<double> temp3 = new List<double>(); //prijs
            List<int> temp2 = new List<int>();       //hoeveelheid
            StreamReader reader = File.OpenText("xml/realtime_stock.txt");
            while (true)
            {
                string sTemp = reader.ReadLine();
                if (sTemp.Equals("end"))
                {
                    break;
                }
                string[] sTemp2 = sTemp.Split(':');
                temp1.Add(sTemp2[0]);
                temp2.Add(int.Parse(sTemp2[1]));
                temp3.Add(double.Parse((sTemp2[2])));
            }
            reader.Close();
            for (int i = 0; i < temp1.Count; i++)
            {
                dranken.Add(new Drank(temp1[i], temp2[i], temp3[i]));
            }
        }
        public void ExportDrank()
        {
            foreach (var line in dranken)
            {
                Console.WriteLine(line.naam + ':' + line.hoeveel + ':' + line.prijs);
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("xml/realtime_stock.txt"))
            {
                foreach (var line in dranken)
                {
                    file.WriteLine(line.naam + ':' + line.hoeveel + ':' + line.prijs);
                }
                file.WriteLine("end");
                file.Close();
            }
        }

        public List<Drank> GetDranken()
        {
            return dranken;
        }

        public void SetDranken(List<Drank> drank)
        {
            dranken = drank;
        }
        public double getPrijs(String naam)
        {
            foreach (var item in dranken)
            {
                if(naam.Equals(item.naam))
                {
                    Console.WriteLine(item.naam + " " + item.sPrijs);
                    return item.prijs;
                }
            }
            return 99999.99;
        }

        internal List<Drank> VerwerkBestelling(List<Drank> _bestellingText)
        {
            foreach (var item1 in _bestellingText)
            {
                foreach (var item2 in dranken)
                {
                    if (item1.naam.Equals(item2.naam))
                    {
                        item2.hoeveel = item2.hoeveel - item1.hoeveel;
                    }
                }
            }
            return dranken;
        }
        internal int getHoeveel(string naam)
        {
            foreach (var item in dranken)
            {
                if (item.naam.Equals(naam))
                {
                    return item.hoeveel;
                }
            }
            return 0;
        }
    }
}
