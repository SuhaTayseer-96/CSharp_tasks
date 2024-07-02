﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._07._2024
{
    internal class Program
    {
        class Car
        {
            public string Carmake { get; set; }
            public int Year { get; set; }
            public string Type { get; set; }
            public double Price { get; set; }
            public string Model { get; set; }
            public string Palletnumber { get; set; }
            public string Color { get; set; }
            public Car(string carmake, int year, string type, double price, string model, string palletnumber, string color)
            {
                Carmake = carmake;
                Year = year;
                Type = type;
                Price = price;
                Model = model;
                Palletnumber = palletnumber;
                Color = color;
            }
            public static void DisplayInfo(string carmake, int year)
            {
                Console.WriteLine($"the car is {carmake} made in {year}");
            }
            public static void DisplayInfo(string carmake)
            {
                Console.WriteLine($"the car is {carmake}");
            }

            public void Display()
            {
                Console.WriteLine("Welcome Car");
            }

            class BMW : Car
            {
                public BMW(string Carmake, int Year, string Type, double Price, string Model, string Palletnumber, string Color)
                : base(Carmake, Year, Type, Price, Model, Palletnumber, Color)
                {


                }
                public void Display()
                {
                    Console.WriteLine("Welcome BMW");
                }

            }

            static void Main(string[] args)
            {

                BMW bmw = new BMW("BMW", 2022, "Sedan", 41.250, "330i", " 6789XYZ", "white");
                bmw.Display();
                Car.DisplayInfo("BMW", 2022);
                Car.DisplayInfo("Bmw");

                //2
                //public interface ISound
                //        {

                //            void MakeSound();

                //        }
                //        public abstract class Animal
                //        {
                //            protected string Name { get; set; }
                //            public Animal(string name)
                //            {
                //                Name = name;
                //            }
                //            public abstract void Eat();
                //            public void Sleep()
                //            {
                //                Console.WriteLine($"tha animal {Name} is Sleeping ");
                //            }

                //        }

                //        public class Dog : Animal, ISound
                //        {
                //            public Dog(string name) : base(name) { }

                //            public override void Eat()
                //            {
                //                Console.WriteLine($"{Name} is eating dog food.");
                //            }

                //            public void MakeSound()
                //            {
                //                Console.WriteLine($"{Name} says Woof 3aw 3aw 3aw!");
                //            }
                //        }

                //        class Cat : Animal, ISound
                //        {
                //            public Cat(string name) : base(name) { }
                //            public override void Eat()
                //            {
                //                Console.WriteLine($"{Name} is eating cat food.");
                //            }
                //            public void MakeSound()
                //            {
                //                Console.WriteLine($"{Name} says Meow meow meow !");
                //            }

                //        }

                //        static void Main(string[] args)
                //        {
                //            Dog dog = new Dog("Summer");
                //            Cat cat = new Cat("winter");
                //            dog.MakeSound();
                //            dog.Sleep();
                //            dog.Eat();
                //            cat.Eat();
                //            cat.Sleep();
                //            cat.MakeSound();
            }
        }
    }
}
