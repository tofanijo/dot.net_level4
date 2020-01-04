using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzpildyti sarasa atsitiktiniais skaiciais. Isvesti visus lyginius skaicius.

            List<int> skaiciai = new List<int>();

            Random rnd = new Random();
            int ilgis = 10;
            for (int i = 0; i < ilgis; i++)

            {
                skaiciai.Add(rnd.Next(1, 1000));

            }
            foreach (var skaicius in skaiciai)
            {
                if(skaicius%2 == 0)
                Console.WriteLine(skaicius);

                Console.WriteLine(skaicius);
            }
            Console.ReadLine();
        }
    }
}
