using Dziedzicenie.Models;

namespace Dziedzicenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog { Name = "Tuzik", Age = 4};
            dog.Eat();
            dog.Bark();
            Cat cat = new Cat { Name = "Barsik",Age = 2};
            cat.Eat();
            cat.Meow();
        }
    }
}
