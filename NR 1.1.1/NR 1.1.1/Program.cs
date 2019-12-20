using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] skaiciai = new double[5];
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Iveskite skaicius {0}", i + 1);
                skaiciai[i] = Convert.ToDouble(Console.ReadLine());
            }




            for (int i = skaiciai.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(skaiciai[i]);
            }
            Console.ReadLine();
        }

       
    }
}
