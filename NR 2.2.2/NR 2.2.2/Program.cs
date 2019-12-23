using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_2._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] skaiciai = new double[6];
            double suma = 0;

            for (int i = 0; i < 6; i++)
            {

                Console.WriteLine("Iveskite skaicius {0}", i + 1);
                skaiciai[i] = Convert.ToDouble(Console.ReadLine());
            }


                foreach(double skaicius in skaiciai)
            {
                suma += skaicius;
            }
                {
                Console.WriteLine("Skaiciu suma: {0}", suma);

                }
            Console.ReadLine();
            }
        }
    }

