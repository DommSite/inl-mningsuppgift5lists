using System;
using System.Collections.Generic;
namespace inlämningsuppgift5lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> löner = new List<int>();
            Console.WriteLine("Skriv in dina månadslöner, avrunda till heltal och avsluta med 0");
            int svar = 1;
            while(svar != 0)
            {
                svar = int.Parse(Console.ReadLine());
                if (svar != 0)
                {
                    löner.Add(svar);
                    Console.WriteLine("Skriv nästa lön eller avsluta med 0");
                }
            }

            Console.WriteLine(medelvärdelön(löner) + " + " + medianlön(löner) );








        }
        static double medelvärdelön(List<int> lön)
        {
            double medelvärde = Queryable.Average(lön.AsQueryable());
            return medelvärde;
        }
        static double medianlön(List<int> lön)
        {
            lön.Sort();
            int median = lön[lön.Count / 2];
            return median;
        }

        
    }

}