using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 0;
            int suma = 0;

            Console.WriteLine("Iveskite bet koki skaiciu");
            if (!int.TryParse(Console.ReadLine(), out skaicius))
            {
                Console.WriteLine("Ivesti neteisingi duomenis");
                Console.ReadLine();
                Environment.Exit(0);
            }

            for (int i = 1; i < skaicius; i+=2)
            {
                Console.WriteLine(i);
                


            }
            Console.ReadLine();
        }
    }
}
