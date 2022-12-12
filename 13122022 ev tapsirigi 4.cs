using System;

namespace _13122022_ev_tapsirig_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş ədədin rəqəmləri cəmini qaytaran metod


            Console.WriteLine("ededi daxil edin:");
            string xStr = Console.ReadLine();

            int x = Convert.ToInt32(xStr);
            
            

            var cemiResult = cemi (x);


            Console.WriteLine(cemiResult);
        }

        static int cemi(int  x)
        {
            int sum = 0;
            while (x>0)
            {
                
                var n = x % 10;
                sum += n;
                x = (x - n) / 10;
                

            }

            return sum;

        }

    }
}

