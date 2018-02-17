using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    class Complex
    {
        public int a, b;

        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static void print(Complex w)
        {
            Console.WriteLine(w);
        }

        public override string ToString()
        {
            return a + "/" + b;
        }

        public Complex add(Complex c)
        {
            Complex result = new Complex(this.a + c.a, this.b + c.b);
            return result;
        }

        public Complex subtract(Complex c)
        {
            Complex result = new Complex(this.a - c.a, this.b - c.b);
            return result;
        }

        public Complex multiply(Complex c)
        {
            Complex result = new Complex(this.a * c.a, this.b * c.b);
            return result;
        }

        public Complex divide(Complex c)
        {
            Complex result = new Complex(this.a / c.a, this.b / c.b);
            return result;
        }

        public static Complex operator +(Complex c, Complex d)
        {
            Complex result = new Complex(c.a + d.a, c.b + d.b);
            return result;
        }

        public static Complex operator -(Complex c, Complex d)
        {
            Complex result = new Complex(c.a - d.a, c.b - d.b);
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(5, 6);
            Complex a1 = new Complex(5, 7);
            Complex.print(a.add(a1));
            Complex b = new Complex(64, 18);
            Complex.print(b.subtract(a1));
            Complex c = new Complex(2, 3);
            Complex.print(c.multiply(a1));
            Complex d = new Complex(8, 3);
            Complex.print(b.divide(d));
            Complex.print(c + d);
            Complex.print(a - c);
            Console.ReadKey();
        }
    }
}