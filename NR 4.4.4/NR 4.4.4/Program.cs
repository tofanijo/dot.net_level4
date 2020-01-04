using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_4._4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < skaiciai.Length; i++)
            {

                skaiciai[i] = rnd.Next(1, 1000);
            }
            foreach (var skaicius in skaiciai)
            {
                Console.WriteLine("{0}", skaicius);
            }
            {
                Console.WriteLine("Maziausias pasirinktas skaicius:", skaiciai);
                {

                }
                {
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }


           
    }
}
