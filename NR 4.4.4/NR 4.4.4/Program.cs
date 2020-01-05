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
            int[] surusiuotiSkaiciai = new int[5];
            int didziausiasSkaicius = 0;
            int maziausiasSkaicius = 0;

            Random rnd = new Random();

            for (int i = 0; i < skaiciai.Length; i++)
            {

                skaiciai[i] = rnd.Next(1, 1000);
            }

            Console.Write("Atsitiktiniu skaiciu masyvas:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($" {skaiciai[i]} ");
            }

            rastiMaziausiaSkaiciu();
            rastiDidziausiaSkaiciu();
            surusiuotiMasyva();

            Array.Copy(skaiciai, 0, surusiuotiSkaiciai, 0, skaiciai.Length);


            Console.WriteLine();
            Console.WriteLine($"Maziausias skaicius yra: {maziausiasSkaicius} ");
            Console.WriteLine($"Didziausias skaicius yra: {didziausiasSkaicius} ");

            Console.Write("Surusiuotu skaiciu masyvas:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" {surusiuotiSkaiciai[i]} ");

            }

            Console.ReadLine();

            int rastiMaziausiaSkaiciu()
            {
                maziausiasSkaicius = skaiciai[0];

                for (int i = 0; i < skaiciai.Length - 1; i++)
                {
                    if (maziausiasSkaicius >= skaiciai[i + 1]) ;
                    {
                        maziausiasSkaicius = skaiciai[i + 1];
                    }
                }

                return maziausiasSkaicius;
                {
                    int rastiDidziausiaSkaiciu()
                    {
                        didziausiasSkaicius = skaiciai[0];

                        for (int i = 0; i < skaiciai.Length - 1; i++)
                        {
                            if (didziausiasSkaicius <= skaiciai[i + 1]) ;
                            {
                                didziausiasSkaicius = skaiciai[i + 1];
                            }

                        }
                        return didziausiasSkaicius;
                    }

                    void surusiuotiMasyva()
                    {
                        for (int i = 0; i < skaiciai.Length - 1; i++)
                        {
                            for (int k = i + 1; k < skaiciai.Length; k++)
                            {
                                if (skaiciai[i] > skaiciai[k])
                                {
                                    (skaiciai[i], skaiciai[k]) = (skaiciai[k], skaiciai[i]);
                                }
                            }
                        }
                    }
                }

            }
        }


    }
}
