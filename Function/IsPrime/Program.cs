using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime;
            Console.WriteLine("Check if the number is prime");
            int num = int.Parse(Console.ReadLine());
            isPrime = IsPrime(num);
            Console.WriteLine(isPrime);
        }

        static bool IsPrime(int num)
        {
            int i = 2;
            bool isPrime = true;
            for (; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
