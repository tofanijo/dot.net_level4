using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            //masyvo uzpildymas atsistiktiniais skaiciais

            int[] skaiciai = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < skaiciai.Length; i++)
            {

                skaiciai[i] = rnd.Next(1, 100);
            }
            foreach (var skaicius in skaiciai)
            {
                Console.WriteLine("{0}, ", skaicius);
            }
            Console.ReadLine();
        }
    }
}


