using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NR_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //progres bar
            for (int i = 0; i < 50; i++)
            {
                //reikia prideti usig System.Threading;
                Thread.Sleep(100); //milisekundes
                System.Console.Write("#"); 
            }
            Console.WriteLine();
            Console.WriteLine("Pabaiga");
        }
    }
}
