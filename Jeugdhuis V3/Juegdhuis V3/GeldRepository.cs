using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Juegdhuis_V3
{
    class GeldRepository
    {
        public int euro500 = 0;
        public int euro200 = 0;
        public int euro100 = 0;
        public int euro50 =0;
        public int euro20 = 0;
        public int euro10 = 0;
        public int euro5 = 0;
        public int euro2 = 0;
        public int euro1 = 0;
        public int euro050 = 0;
        public int euro020 = 0;
        public int euro010 = 0;
        public int euro005 = 0;
        public int euro002 = 0;
        public int euro001 = 0;
        public GeldRepository()
        {

        }
        public GeldRepository(int euro500,int euro200,int euro100,int euro50, int euro20, int euro10, int euro5, int euro2, int euro1, int euro050, int euro020, int euro010, int euro005, int euro002, int euro001)
        {
            this.euro500 = euro500;
            this.euro200 = euro200;
            this.euro100 = euro100;
            this.euro50 = euro50;
            this.euro20 = euro20;
            this.euro10 = euro10;
            this.euro5 = euro5;
            this.euro2 = euro2;
            this.euro1 = euro1;
            this.euro050 = euro050;
            this.euro020 = euro020;
            this.euro010 = euro010;
            this.euro005 = euro005;
            this.euro002 = euro002;
            this.euro001 = euro001;
        }

        public void Clr()
        {
            euro500 = 0;
            euro200 = 0;
            euro100 = 0;
            euro50 = 0;
            euro20 = 0;
            euro10 = 0;
            euro5 = 0;
            euro2 = 0;
            euro1 = 0;
            euro050 = 0;
            euro020 = 0;
            euro010 = 0;
            euro005 = 0;
            euro002 = 0;
            euro001 = 0;
        }
        public void inportAsList(List<Eenheid> test)
        {
            euro500 = test[0].hoeveel;
            euro200 = test[1].hoeveel;
            euro100 = test[2].hoeveel;
            euro50 = test[3].hoeveel;
            euro20 = test[4].hoeveel;
            euro10 = test[5].hoeveel;
            euro5 = test[6].hoeveel;
            euro2 = test[7].hoeveel;
            euro1 = test[8].hoeveel;
            euro050 = test[9].hoeveel;
            euro020 = test[10].hoeveel;
            euro010 = test[11].hoeveel;
            euro005 = test[12].hoeveel;
            euro002 = test[13].hoeveel;
            euro001 = test[14].hoeveel;
        }
        public double Totaal()
        {
            var totaal =
                euro500*500+
                euro200*200+
                euro100*100+
                euro50*50 +
                euro20*20 +
                euro10*10 +
                euro5*5 +
                euro2*2 +
                euro1*1 +
                euro050*0.50 +
                euro020*0.20 +
                euro010*0.10 +
                euro005*0.05 +
                euro002*0.02 +
                euro001*0.01;
            totaal = System.Math.Floor(totaal * 100) / 100;
            return totaal;
        }


        public void RemoveLast(string nummer)
        {
            switch (nummer)
            {
                case "€0,01":
                    euro001--;
                    break;
                case "€0,02":
                    euro002--;
                    break;
                case "€0,05":
                    euro005--;
                    break;
                case "€0,10":
                    euro010--;
                    break;
                case "€0,20":
                    euro020--;
                    break;
                case "€0,50":
                    euro050--;
                    break;
                case "€1":
                    euro1--;
                    break;
                case "€2":
                    euro2--; 
                    break;
                case "€5":
                    euro5--;
                    break;
                case "€10":
                    euro10--;
                    break;
                case "€20":
                    euro20--;
                    break;
                case "€50":
                    euro50--;
                    break;
                case "€100":
                    euro100--;
                    break;
                case "€200":
                    euro200--;
                    break;
                case "€500":
                    euro500--;
                    break;
                default:
                    break;
            }
        }
        public void Import(String import)
        {

            Clr();
            List<int> temp = new List<int>();
            StreamReader reader = File.OpenText("xml/"+import+".txt");
            while (true)
            {
                string sTemp = reader.ReadLine();
                if (sTemp.Equals("end"))
                {
                    break;
                }
                string[] sTemp2 = sTemp.Split(':');
                temp.Add(int.Parse(sTemp2[1]));
            }
            reader.Close();
            euro500 = temp[0];
            euro200 = temp[1];
            euro100 = temp[2];
            euro50 = temp[3];
            euro20 = temp[4];
            euro10 = temp[5];
            euro5 = temp[6];
            euro2 = temp[7];
            euro1 = temp[8];
            euro050 = temp[9];
            euro020 = temp[10];
            euro010 = temp[11];
            euro005 = temp[12];
            euro002 = temp[13];
            euro001 = temp[14];
        }
        
        public void Export(string export)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("xml/"+export+".txt"))
            {
                foreach (var line in this.toObject())
                {
                    file.WriteLine(line.eenheidC + ':' + line.hoeveel);
                }
                file.WriteLine("end");
                file.Close();
            }
        }
        public List<Eenheid> toObject()
        {
            List<Eenheid> test = new List<Eenheid>();
            test.Add(new Eenheid("500", euro500));
            test.Add(new Eenheid("200", euro200));
            test.Add(new Eenheid("100", euro100));
            test.Add(new Eenheid("50", euro50));
            test.Add(new Eenheid("20", euro20));
            test.Add(new Eenheid("10", euro10));
            test.Add(new Eenheid("5", euro5));
            test.Add(new Eenheid("2", euro2));
            test.Add(new Eenheid("1", euro1));
            test.Add(new Eenheid("0,50", euro050));
            test.Add(new Eenheid("0,20", euro020));
            test.Add(new Eenheid("0,10", euro010));
            test.Add(new Eenheid("0,05", euro005));
            test.Add(new Eenheid("0,02", euro002));
            test.Add(new Eenheid("0,01", euro001));
            return test;
        }
        public List<Eenheid> BerekenTeruggave(double d)
        {
            int e500 = 0;
            int e200 = 0;
            int e100 = 0;
            int e50 =0;
            int e20 = 0;
            int e10 = 0;
            int e5 = 0;
            int e2 = 0;
            int e1 = 0;
            int e050 = 0;
            int e020 = 0;
            int e010 = 0;
            int e005 = 0;
            int e002 = 0;
            int e001 = 0;
            List<Eenheid> test = new List<Eenheid>();

            Start:
                if (euro500 - e500 > 0)
                {
                    if (d >= 500)
                    {
                        e500++;
                        d = d - 500;
                        
                        goto Start;
                    }
                }
                else
                {
                    Console.WriteLine("briefjes van 500 op");
                }
                if (euro200 - e200 > 0)
                {
                    if (d >= 200)
                    {
                        e200++;
                        d = d - 200;
                        
                        goto Start;
                    }
                }
                else
                {
                    Console.WriteLine("briefjes van 200 op");
                }
                if (euro100 - e100 > 0)
                {
                    if (d >= 100)
                    {
                        e100++;
                        d = d - 100;
                        
                        goto Start;
                    }
                }
                else
                {
                    Console.WriteLine("briefjes van 100 op");
                }
                if (euro50 - e50 > 0)
                {
                    if (d >= 50)
                    {
                        e50++;
                        d = d - 50;
                        
                        goto Start;
                    }
                }
                else
                {
                    Console.WriteLine("briefjes van 50 op");
                }
                if (euro20 - e20 > 0)
                {
                    if (d >= 20)
                    {
                        e20++;
                        d = d - 20;
                        
                        goto Start;
                    }
                }
                else
                {
                    Console.WriteLine("briefjes van 20 op");
                }
                if (euro10 - e10 > 0)
                {
                    if (d >= 10)
                    {
                        e10++;
                        d = d - 10;
                        
                        goto Start;
                    }
                }
                else
                {
                    Console.WriteLine("briefjes van 10 op");
                }
                if (euro5 - e5 > 0)
                {
                    if (d >= 5)
                    {
                        e5++;
                        d = d - 5;
                        
                        goto Start;
                    }
                }
                else
                {
                    Console.WriteLine("briefjes van 5 op");
                }
            
                if (euro2 - e2 > 0)
                {

                if (d >= 2)
                    {
                        e2++;
                        d = d - 2;
                        
                        goto Start;
                    }
                }
                else
                {
                    Console.WriteLine("briefjes van 2 op");
                }
                if (euro1 - e1 > 0)
                {
                    if (d >= 1)
                    {
                        e1++;
                        d = d - 1;
                        
                        goto Start;
                    }
                }
                else
                {
                    Console.WriteLine("briefjes van 1 op");
                }
                if (euro050 - e050 > 0)
                {
                    if (d >= 0.5)
                    {
                        e050++;
                        d = d - 0.5;
                    d = Math.Round(d, 2);
                    Console.WriteLine("-0,50");
                    goto Start;
                    }
                }
                else
                {
                    Console.WriteLine("briefjes van 0,50 op");
                }
                if (euro020 - e020 > 0)
                {
                    if (d >= 0.2)
                    {
                        e020++;
                        d = d - 0.2;
                        d = Math.Round(d, 2);
                    Console.WriteLine("-0,20");
                        goto Start;
                    }
                }
                else
                {
                    Console.WriteLine("briefjes van 0,20 op");
                }
                if (euro010 - e010 > 0)
                {
                    if (d >= 0.1)
                    {
                        e010++;
                        d = d - 0.1;
                    d = Math.Round(d, 2);
                    Console.WriteLine("-0,10");
                    goto Start;
                    }
                }
                else
                {
                    Console.WriteLine("briefjes van 0,10 op");
                }
                if (euro005 - e005 > 0)
                {
                    if (d >= 0.05)
                    {
                        e005++;
                        d = d - 0.05;
                    d = Math.Round(d, 2);
                    Console.WriteLine("-0,05");
                    goto Start;
                    }
                }
                else
                {
                    Console.WriteLine("briefjes van 0,05 op");
                }
                if (euro002 - e002 > 0)
                {
                    if (d >= 0.02)
                    {
                        e002++;
                        d = d - 0.02;
                    d = Math.Round(d, 2);
                    goto Start;
                    }
                }
                else
                {
                    Console.WriteLine("briefjes van 0,02 op");
                }
                if (euro001 - e001 > 0)
                {
                    if (d >= 0.01)
                    {
                        e001++;
                        d = d - 0.01;
                    d = Math.Round(d, 2);
                    goto Start;
                    }
                }
                else
                {
                    Console.WriteLine("briefjes van 0,01 op");
                }
                if (d == 0)
                {
                    if (e500 > 0)
                    {
                        test.Add(new Eenheid("500", e500));
                    }
                    if (e200 > 0)
                    {
                        test.Add(new Eenheid("200", e200));
                    }
                    if (e100 > 0)
                    {
                        test.Add(new Eenheid("100", e100));
                    }
                    if (e50 > 0)
                    {
                        test.Add(new Eenheid("50", e50));
                    }
                    if (e20 > 0)
                    {
                        test.Add(new Eenheid("20", e20));
                    }
                    if (e10 > 0)
                    {
                        test.Add(new Eenheid("10", e10));
                    }
                    if (e5 > 0)
                    {
                        test.Add(new Eenheid("5", e5));
                    }
                    if (e2 > 0)
                    {
                        test.Add(new Eenheid("2", e2));
                    }
                    if (e1 > 0)
                    {
                        test.Add(new Eenheid("1", e1));
                    }
                    if (e050 > 0)
                    {
                        test.Add(new Eenheid("0,5", e050));
                    }
                    if (e020 > 0)
                    {
                        test.Add(new Eenheid("0,2", e020));
                    }
                    if (e010 > 0)
                    {
                        test.Add(new Eenheid("0,1", e010));
                    }
                    if (e005 > 0)
                    {
                        test.Add(new Eenheid("0,05", e005));
                    }
                    if (e002 > 0)
                    {
                        test.Add(new Eenheid("0,02", e002));
                    }
                    if (e001 > 0)
                    {
                        test.Add(new Eenheid("0,01", e001));
                    }
                   
                }
                Console.WriteLine("Start berekening teruggave");
                bool isNotEmpty = test.Any();
                if (isNotEmpty)
                {
                    return test;
                }
                else
                {
                    return null;
                }
           
        }


        internal void afTrekken(List<Eenheid> list)
        {
            if (list !=null )
            {
                foreach (var item in list)
                {
                    if (item.eenheidNC.Equals("500"))
                    {
                        euro500 = euro500 - item.hoeveel;
                    }
                    if (item.eenheidNC.Equals("200"))
                    {
                        euro200 = euro200 - item.hoeveel;
                    }
                    if (item.eenheidNC.Equals("100"))
                    {
                        euro100 = euro100 - item.hoeveel;
                    }
                    if (item.eenheidNC.Equals("50"))
                    {
                        euro50 = euro50 - item.hoeveel;
                    }
                    if (item.eenheidNC.Equals("20"))
                    {
                        euro20 = euro20 - item.hoeveel;
                    }
                    if (item.eenheidNC.Equals("10"))
                    {
                        euro10 = euro10 - item.hoeveel;
                    }
                    if (item.eenheidNC.Equals("5"))
                    {
                        euro5 = euro5 - item.hoeveel;
                    }
                    if (item.eenheidNC.Equals("2"))
                    {
                        euro2 = euro2 - item.hoeveel;
                    }
                    if (item.eenheidNC.Equals("1"))
                    {
                        euro1 = euro1 - item.hoeveel;
                    }
                    if (item.eenheidNC.Equals("0,50"))
                    {
                        euro050 = euro050 - item.hoeveel;
                    }
                    if (item.eenheidNC.Equals("0,20"))
                    {
                        euro020 = euro020 - item.hoeveel;
                    }
                    if (item.eenheidNC.Equals("0,10"))
                    {
                        euro010 = euro010 - item.hoeveel;
                    }
                    if (item.eenheidNC.Equals("0,05"))
                    {
                        euro005 = euro005 - item.hoeveel;
                    }
                    if (item.eenheidNC.Equals("0,02"))
                    {
                        euro002 = euro002 - item.hoeveel;
                    }
                    if (item.eenheidNC.Equals("0,01"))
                    {
                        euro001 = euro001 - item.hoeveel;
                    }


                }
            }
           
        }
        internal void optellenKassa(Dictionary<string, int> _kassaText)
        {
            if (_kassaText != null)
            {
                foreach (var item in _kassaText)
                {
                    Console.WriteLine(item.Key + " : " + item.Value);
                    if (item.Key.Equals("€500"))
                    {
                        euro500 = euro500 + item.Value;
                    }
                    if (item.Key.Equals("€200"))
                    {
                        euro200 = euro200 + item.Value;
                    }
                    if (item.Key.Equals("€100"))
                    {
                        euro100 = euro100 + item.Value;
                    }
                    if (item.Key.Equals("€50"))
                    {
                        euro50 = euro50 + item.Value;
                    }
                    if (item.Key.Equals("€20"))
                    {
                        euro20 = euro20 + item.Value;
                    }
                    if (item.Key.Equals("€10"))
                    {
                        euro10 = euro10 + item.Value;
                    }
                    if (item.Key.Equals("€5"))
                    {
                        euro5 = euro5 + item.Value;
                    }
                    if (item.Key.Equals("€2"))
                    {
                        euro2 = euro2 + item.Value;
                    }
                    if (item.Key.Equals("€1"))
                    {
                        euro1 = euro1 + item.Value;
                    }
                    if (item.Key.Equals("€0,50"))
                    {
                        euro050 = euro050 + item.Value;
                    }
                    if (item.Key.Equals("€0,20"))
                    {
                        euro020 = euro020 + item.Value;
                    }
                    if (item.Key.Equals("€0,10"))
                    {
                        euro010 = euro010 + item.Value;
                    }
                    if (item.Key.Equals("€0,05"))
                    {
                        euro005 = euro005 + item.Value;
                    }
                    if (item.Key.Equals("€0,02"))
                    {
                        euro002 = euro002 + item.Value;
                    }
                    if (item.Key.Equals("€0,01"))
                    {
                        euro001 = euro001 + item.Value;
                    }


                }
            }
        }
        internal GeldRepository Merge(GeldRepository invoer1,GeldRepository invoer2)
        {
            invoer2.euro500 = invoer2.euro500 + invoer1.euro500;
            invoer2.euro200 = invoer2.euro200 + invoer1.euro200;
            invoer2.euro100 = invoer2.euro100 + invoer1.euro100;
            invoer2.euro50 = invoer2.euro50 + invoer1.euro50;
            invoer2.euro20 = invoer2.euro20 + invoer1.euro20;
            invoer2.euro10 = invoer2.euro10 + invoer1.euro10;
            invoer2.euro5 = invoer2.euro5 + invoer1.euro5;
            invoer2.euro2 = invoer2.euro2 + invoer1.euro2;
            invoer2.euro1 = invoer2.euro1 + invoer1.euro1;
            invoer2.euro050 = invoer2.euro050 + invoer1.euro050;
            invoer2.euro020 = invoer2.euro020 + invoer1.euro020;
            invoer2.euro010 = invoer2.euro010 + invoer1.euro010;
            invoer2.euro005 = invoer2.euro005 + invoer1.euro005;
            invoer2.euro002 = invoer2.euro002 + invoer1.euro002;
            invoer2.euro001 = invoer2.euro001 + invoer1.euro001;
            return invoer2;
        }
        
        internal bool isEmpty()
        {
            if (euro500==0 && euro200==0 && euro100==0 && euro50 == 0 && euro20 == 0 && euro10 == 0 && euro5 == 0 && euro2 == 0 && euro1 == 0 && euro050 == 0 && euro020 == 0 && euro010 == 0 && euro005 == 0 && euro002 == 0 && euro001 == 0)
            {
                return true;
            }else
            {
                return false;
            }

        }
    }
}
