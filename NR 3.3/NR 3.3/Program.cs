using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sakynis;
            Console.WriteLine("Iveskite sakyni");
            sakynis = Console.ReadLine();

            for (int i = sakynis.Length - 1; i >= 0; i--)
            {
                 Console.Write(sakynis[i]);
            }
            Console.ReadLine();
        }
        
    }
}
