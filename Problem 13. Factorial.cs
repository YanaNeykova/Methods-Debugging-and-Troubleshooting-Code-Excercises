using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FactorialOfNumber(number));
        }

        private static BigInteger FactorialOfNumber(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            BigInteger factorial = number;
            for (int i = number - 1; i > 1; i--)
            {
                factorial = BigInteger.Multiply(factorial, i);
            }

            return factorial;
        }
    }
}
