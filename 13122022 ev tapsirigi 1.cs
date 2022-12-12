using System;

namespace _13122022_tapsiriq_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod


            Console.WriteLine("birinci ededi daxil edin:");
            string xStr = Console.ReadLine();

            Console.WriteLine("ikinci ededi daxil edin:");
            string yStr = Console.ReadLine();

            int x = Convert.ToInt32(xStr);
            int y = Convert.ToInt32(yStr);

            var sumResult = Sum(x, y);
            Console.WriteLine(sumResult);
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
