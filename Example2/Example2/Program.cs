using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Fruit
    {
        int mass, price;
        string name, color;


        public void Read()
        {
            Console.WriteLine("Fruit?");
            this.name = Console.ReadLine();
            Console.WriteLine("Mass?");
            this.mass = int.Parse(Console.ReadLine());
            Console.WriteLine("Color?");
            this.color = Console.ReadLine();
            Console.WriteLine("Price?");
            this.price = int.Parse(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine(name + " " + mass + " " + color + " " + price + " " + "\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit();
            Fruit frut1 = new Fruit();

            fruit.Read();

            fruit.Show();

            frut1.Read();
            frut1.Show();

            Console.ReadKey();
        }
    }
}
