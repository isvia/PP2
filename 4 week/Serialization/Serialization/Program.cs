using System;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    // класс и его члены объявлены как public
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // стандартный конструктор без параметров
        public Person()
        { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // объект для сериализации
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string text = Console.ReadLine();
            int age = int.Parse(text);
            Person person = new Person(name, age);
            Console.WriteLine("Object created");

            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(Person));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);

                Console.WriteLine("Object serialized");
            }

            // десериализация
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                Person newPerson = (Person)formatter.Deserialize(fs);

                Console.WriteLine("Object deserialized");
                Console.WriteLine("Name: {0} --- Age: {1}", newPerson.Name, newPerson.Age);
            }

            Console.ReadLine();
        }
    }
}
