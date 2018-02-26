using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, m;

            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    Console.Write("0");
                }

                Console.WriteLine("0");

            }

                Console.ReadKey();
        }
    }
}
