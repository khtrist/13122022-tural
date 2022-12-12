using System;

namespace _3_ev_tapsirigi_13122022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod
            //Console.WriteLine("Yazida a herfi varmi?");
            //
            //char herif = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("yazida a herfi var ?");

            string soz = Console.ReadLine();
            var result = herif(soz);
            Console.WriteLine(result);
        }
        static bool herif(string soz) 
        {
            var has = false;
            for (int i = 0; i < soz.Length; i++)
            {
                if (soz[i] == 'a')
                {
                    has = true; 
                    break;

                }
                else
                {
                    has = false;
                }
            }
            return has; 
        
        
        }
    }
}
