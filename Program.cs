using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> showroom= new HashSet<string>();
            showroom.Add("Viper");
            showroom.Add("Tesla");
            showroom.Add("Silverado");
            showroom.Add("Corvette");

            showroom.Add("Silverado");
          
            HashSet<string> usedLot= new HashSet<string>();
            usedLot.Add("Altima");
            usedLot.Add("Town Car");
            showroom.UnionWith(usedLot);
            showroom.Remove("Town Car");

           
            HashSet<string> junkYard= new HashSet<string>();
            junkYard.Add("Escort");
            junkYard.Add("Camry");
            junkYard.Add("Corevette");

            showroom.UnionWith(junkYard);
            showroom.Remove("Camry");

             foreach(string x in showroom){
                Console.WriteLine(x);
            }
        }
    }
}
