using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "CKursas";
            for (int i = 0; i < vardas.Length; i++)
            {
                char current = vardas[i];
                Console.WriteLine(current);
            }
            Console.ReadLine();
                }
    }
}
