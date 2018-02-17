using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primenumbers
{

    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split(' ');
            int ch;
            for (int i = 0; i < arr.Length; i++)
            {
                ch = int.Parse(arr[i]);

                if (IsPrime(ch))
                {
                    Console.WriteLine(ch);
                }
            }

            Console.ReadKey();
        }

        static bool IsPrime(int n)
        {
            if (n == 1 || n == 0)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); ++i)
            {
                if (n % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
    }

}