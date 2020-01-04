using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_3._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] ivestiSkaiciai = new double[5];


            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Iveskite skaicius {0}", i + 1);
                ivestiSkaiciai[i] = Convert.ToDouble(Console.ReadLine());
            }


            Console.WriteLine("Pries:");
            foreach (var skaicius in ivestiSkaiciai)
            {
                Console.Write(skaicius);
            }


            Console.ReadLine();
        }
    }
}
