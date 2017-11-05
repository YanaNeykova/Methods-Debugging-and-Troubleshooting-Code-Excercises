using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMax_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(numbers));
        }

        static int GetMax(int[] numbers)
        {
            int maxNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                if (numbers[i] > maxNumber)
                    maxNumber = numbers[i];
            return maxNumber;

        }
    }
}
