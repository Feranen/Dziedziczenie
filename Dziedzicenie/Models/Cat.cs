using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedzicenie.Models
{
    public class Cat : Animal
    {
        //public string Name { get; set; } = "";
        //public int Age { get; set; }
        //public void Eat()
        //{
        //    Console.WriteLine($"{Name} je");
        //}
        public void Meow() {
            Console.WriteLine($"{Name} MIAU!!");
        }
    }
}
