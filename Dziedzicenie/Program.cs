using Dziedzicenie.Models;
using Dziedzicenie.Models.Task;

namespace Dziedzicenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// virtual - allow methods to be replaced
            //// override - replace virtual method
            //// protected - private, but available to children
            //// ClassA.Test() -> ClassB. Class B have access to .Test(), but other not
            //Dog dog = new Dog("Tuzik",2);
            //dog.Eat();
            //dog.MakeSound();
            //dog.Sleep();
            //Cat cat = new Cat("Barsik","Czrny", 2);
            //cat.Eat();
            //cat.MakeSound();
            //cat.Sleep();
            //var dog2 = new Dog(dog);
            Circle circle = new Circle() {name = "SDddddd", Radius = 5.212};
            Rectangle rectangle = new Rectangle() { name = "dfgdfg", height = 4.12, width = 43.1};

            Console.WriteLine(circle.GetArea());
            Console.WriteLine(rectangle.GetArea());
            

        }
    }
}
