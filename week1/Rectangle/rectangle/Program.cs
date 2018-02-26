using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle
{
    class rectangle
    {
        public int h1, w1,peri,area;
        public rectangle(int w,int h)
        {
            h1 = h;
            w1 = w;
            getarea();
            getperi();

        }
        public void getarea()
        {
            area = h1 * w1;
        }
        public void getperi()
        {
            peri = 2*(h1 + w1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your width?");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your height?");
            int h = int.Parse(Console.ReadLine());
            rectangle a = new rectangle(w, h);
            Console.WriteLine("Area =" + a.area);
            Console.WriteLine("Perimetr =" + a.peri);
            Console.ReadKey();
        }
    }
}
