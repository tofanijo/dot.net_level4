using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
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

            for (int i = 0; i < savaitesDienos.Length; i++)
            {
                Console.WriteLine(savaitesDienos[i]);

            }
            Console.ReadLine();

            }
        }
    }



