using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.Write(i + " ");
                }
            }

        }

        static bool IsPrimeNumber(int num)

        {

            bool bPrime = true;

            int factor = num / 2;



            int i = 0;



            for (i = 2; i <= factor; i++)

            {

                if ((num % i) == 0)

                    bPrime = false;

            }

            return bPrime;

        }

    }
}
