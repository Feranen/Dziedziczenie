using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedzicenie.Models
{
    public class Cat : Animal
    {
        public string Color { get; set; } = "";
        //public string Name { get; set; } = "";
        //public int Age { get; set; }
        //public void Eat()
        //{
        //    Console.WriteLine($"{Name} je");
        //}
        public Cat(string name, string color, int age) : base(name, age) { 
            Color = color;
        } // Konstructor
        public override void MakeSound() { // Overwrite method
            Console.WriteLine($"{Name} MIAU!!");
        }
    }
}
