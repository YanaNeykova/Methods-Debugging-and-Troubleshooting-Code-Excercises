using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4. Numbers_in_reversed_order
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            int places = 0;
            int times = 0;
            decimal reversed = 0;

            while (n % 1 > 0)
            {
                n *= 10;
                places++;
            }

            do
            {
                int remainder = (int)n % 10;
                reversed = reversed * 10 + remainder;
                n = (int)n / 10;
                times++;
            }
            while (n > 0);

            if (places > 0)
            {
                int division = (int)Math.Pow(10, times - places);
                reversed = reversed / division;
            }

            Console.WriteLine(reversed);
        }
    }
}
