using System;

namespace _13122022_eb_tapsirigi_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş 4 ədədin ortalamasını tapıb qaytaran metod
            Console.WriteLine("1 ci ededi daxil edin");
            var eded1 = Console.ReadLine(); 
            var eded1Num = Convert.ToInt32(eded1);
            Console.WriteLine("2 ci ededi daxil edin");
            var eded2 = Console.ReadLine(); 
            var eded2Num = Convert.ToInt32(eded2);
            Console.WriteLine("3 cu ededi daxil edin");
            var eded3 = Console.ReadLine();
            var eded3Num = Convert.ToInt32(eded3);
            Console.WriteLine("4cu ededi daxil edin");
            var eded4 = Console.ReadLine(); 
            var eded4Num = Convert.ToInt32(eded4);

            var result = ededlerintenortasi(eded1Num, eded2Num, eded3Num, eded4Num);
            Console.WriteLine(result);

        }
        static int ededlerintenortasi(int Num1, int Num2, int Num3, int Num4)
        {
            Console.WriteLine("ededlerin ten ortasi");
            return (Num1 + Num2 + Num3 + Num4) / 4;
            
            




        
        
        
        }


    }
}
