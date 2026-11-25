using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedzicenie.Models
{

    public class Dog : Animal // .. : klasaBazowa
    {

        //public string Name { get; set; } = "";
        //public int Age { get; set; }
        //public void Eat()
        //{
        //    Console.WriteLine($"{Name} je");
        //}

        //Przeciążanie
        public Dog() : this("", 0) { // this watch for same vars type
        
        }

        public Dog(Dog dog) : base(dog.Name, dog.Age) {  // Copy constructor
            Name = dog.Name;
            Age = dog.Age;
        }
        public Dog(string name, int age) : base(name, age) {
        
        }
        public override void MakeSound() // Overwrite method
        {
            Console.WriteLine($"{Name}: Hau.. Hau..");
        }
    }
}
