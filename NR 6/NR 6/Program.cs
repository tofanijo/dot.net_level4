using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius1 = 0;
            int suma = 0;

            Console.WriteLine("Iveskite bet koki skaiciu");
            if (!int.TryParse(Console.ReadLine(), out skaicius1))
            {
                Console.WriteLine("Ivesti neteisingi duomenis");
                Console.ReadLine();
                Environment.Exit(0);
            }

            for (int i = 1; i <= skaicius1; i++) //for Tab * 2
            {
                Console.WriteLine(i);
                suma = i + suma;
                Console.WriteLine(suma);
            }
            Console.ReadLine();
        }
    }
}
