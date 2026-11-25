using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedzicenie.Models
{
    public class Animal
    {
        // Klasa bazowa 
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} je");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} spi");
        }
    }
}
