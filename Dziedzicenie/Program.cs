using Dziedzicenie.Models;

namespace Dziedzicenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog { Name = "Tuzik", Age = 4 };
            dog.Eat();
            dog.Bark();
            dog.Sleep();
            Cat cat = new Cat("Barsik","Czrny", 2);
            cat.Eat();
            cat.Meow();
            cat.Sleep();
        }
    }
}
