using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] savaitesDienos =
            {
                "Pirmadienis",
                 "Antradienis",
                  "Treciadienis",
                   "Ketvirdatienis",
                    "Penktadienis",
                     "Sestadienis",
                      "Sekmadienis",
            };

            Console.WriteLine("Pries:");
            foreach (var diena in savaitesDienos)
            {
                Console.WriteLine(diena);
            }
            savaitesDienos[2] = "TRECIADIENIS";

                Console.WriteLine("");
            Console.WriteLine("Po:");
            foreach (var diena in savaitesDienos)
            {
                Console.WriteLine(diena);
            }
            Console.ReadLine();
        }
    }
}
