using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            List<RealEstate> realEstate = new List<RealEstate>();
            realEstate.Add(new RealEstate("house", 50000.8, 30, "Kaunas"));
            realEstate.Add(new RealEstate("house", 57000.8, 48.5, "Vilnius"));
            realEstate.Add(new RealEstate("house", 50000.8, 30, "Kaunas"));
            realEstate.Add(new RealEstate("house", 48000, 48.5, "Vilnius"));
            realEstate.Add(new RealEstate("house", 50000.8, 48.5, "Kaunas"));
            realEstate.Add(new RealEstate("house", 48400, 30, "Vilnius"));
            realEstate.Add(new RealEstate("house", 48000, 48.5, "Kaunas"));
            realEstate.Add(new RealEstate("house", 28000, 48.5, "Vilnius"));
            realEstate.Add(new RealEstate("house", 30000.8, 30, "Kaunas"));



            for (int i = 0; i < realEstate.Count; i++)
            {
                for (int a = i + 1; a < realEstate.Count; a++)
                {
                    if (string.Compare(realEstate[i].city, realEstate[a].city) > 0)
                    {
                        RealEstate reTmp = realEstate[i];
                        realEstate[i] = realEstate[a];
                        realEstate[a] = reTmp;
                    }
                }
            }


            for (int i = 0; i < realEstate.Count; i++)
            {
                for (int a = i + 1; a < realEstate.Count; a++)
                {
                    if (string.Compare(realEstate[i].city, realEstate[a].city) == 0)
                    {
                        if (realEstate[i].price > realEstate[a].price)
                        {
                            RealEstate reTmp = realEstate[i];
                            realEstate[i] = realEstate[a];
                            realEstate[a] = reTmp;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }


            for (int i = 0; i < realEstate.Count; i++)
            {
                Console.WriteLine(realEstate[i].ToString());
            }

        }
    }
}
