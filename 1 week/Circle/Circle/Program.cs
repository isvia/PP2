using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class circle
    {
        public int r1;
        public double diam, circ, area;
        public circle (int r)
        {
            r1 = r;
            getarea();
            getdiam();
            getcirc();
        }
        public void getarea()
        {
            area = 3.14*r1*r1;
        }
        public void getdiam()
        {
            diam = 2*r1;
        }
        public void getcirc()
        {
            circ = 2 * 3.14 * r1;

        }
    }

    internal class publuc
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your radius?");
            int r = int.Parse(Console.ReadLine());
            circle a = new circle(r);
            Console.WriteLine("Area=" + a.area);
            Console.WriteLine("Diametr=" + a.diam);
            Console.WriteLine("Circumference=" + a.circ);
            Console.ReadKey();
        }
    }
}
