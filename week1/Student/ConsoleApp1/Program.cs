using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class student
        {
            int age;
            string name;
            public student(string name,int age)
            {
                this.name = name;
                this.age = age;
            }

            public override string ToString()
            {
                return "name is -"+name+"\nage is="+age ;
            }
        }
        class rectangle
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string text = Console.ReadLine();
            int age = int.Parse(text);
            student a = new student(name, age);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
