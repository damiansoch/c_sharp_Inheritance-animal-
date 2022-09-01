using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Oreo", 1);
            Console.WriteLine($"{dog.Name} is {dog.Age} year old.");
            dog.MakeSound();
            dog.Play();
            dog.Eat();
        }
    }
}
