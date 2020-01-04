using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Padaryti viena studentu sarasa. 
            //Padryti antra veliau atvykusiu studentu sarasa. 
            //Sujungti abu sarasus, surusiuoti ir isvesti.

            List<string> sarasas1 = new List<string>();
            sarasas1.Add("Renata");
            sarasas1.Add("Ausra");
            sarasas1.Add("Valentinas");
            sarasas1.Add("Bronius");

            List<string> sarasas2 = new List<string>();
            sarasas2.Add("Rimantas");
            sarasas2.Add("Tadas");
            sarasas2.Add("Tomas");
            sarasas2.Add("Saule");

            Console.WriteLine("Studentu sarasas:");
            isvestiSarasa();
            Console.WriteLine();

            sarasas1.AddRange(sarasas2);
            Console.WriteLine("Papildytas studentu sarasas:");
            isvestiSarasa();
            Console.WriteLine();

            sarasas1.Sort();
            Console.WriteLine("Surusiuotas studentu sarasas:");
            isvestiSarasa();

            void isvestiSarasa()
            {
                foreach (var item in sarasas1)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }
        }
    }
}
