using ConsoleApp3.AnimalNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        /* 1
        static void Main(string[] args)
        {
            int temperature = 22;

            string city = "San Francisco";

            for (int day = 1; day <= 7; day++)
            {
                double temperatureInFahrenheit = (temperature * 9.0 / 5.0) + 32;

                Console.WriteLine($"In {city} on day {day}, the temperature is {temperatureInFahrenheit}°F.");
            }
        } */


        /* 2
        static void Main(string[] args)
        {
            Student student = new Student("Robi", "A");
            Console.WriteLine(student.Greeting());
        } */


        /* 3
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.CalculateArea(3, 4);  // Example: base=3, height=4

            Square square = new Square();
            square.CalculateArea(5);  // Example: side=5
        } */


        /* 4
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine($"Dog says: {dog.MakeSound()}");

            Cat cat = new Cat();
            Console.WriteLine($"Cat says: {cat.MakeSound()}");
        } */


        /* 5
        static void Main(string[] args)
        {
            MyCollection<string> stringCollection = new MyCollection<string>();

            stringCollection.AddItem("Hello");
            stringCollection.AddItem("World");
            stringCollection.AddItem("Generic");

            Console.WriteLine(stringCollection.GetItem(0)); // Outputs: Hello
            Console.WriteLine(stringCollection.GetItem(1)); // Outputs: World
            Console.WriteLine(stringCollection.GetItem(2)); // Outputs: Generic
        } */
    }
}
