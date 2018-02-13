using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    class complex
    {
        public int a1, b1, e1, d1;
        public complex(int a, b, e, d)
        {
            a1 = a;
            b1 = b;
            e1 = e;
            d1 = d;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split(' ');

            Complex c1 = new Complex(a, b); 
            Complex c2 = new Complex(e, d); 

            Complex result = c1 + c2;
            Complex result1 = c1 - c2; 

            Console.WriteLine(result);
            Console.WriteLine(result1); 



            Console.ReadKey();
        }
    }
}