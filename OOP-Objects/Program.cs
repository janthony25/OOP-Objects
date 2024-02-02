using System;

namespace MyFirstProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields & methods (characteristics & actions)

            Human human1 = new Human();
            Car car1 = new Car();

            human1.name = "Rick";
            human1.age = 65;

            car1.carMake = "BMW";

            human1.Eat();
            human1.Sleep();
            Console.WriteLine($"Hello {human1.name}");

            car1.carStats();

            Console.ReadKey();
        }
    }

    class Human
    {
        public string name;
        public int age;

        public void Eat()
        {
            Console.WriteLine($"{name} is eating");
        }

        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping");
        }
    }

    class Car
    {
        public string carMake;
        
        public void carStats()
        {
            Console.WriteLine($"You have a nice {carMake}");
        }
    }
}