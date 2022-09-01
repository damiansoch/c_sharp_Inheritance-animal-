using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog : Animal
    {
        public bool IsHappy { get; set; }//prop only for the dog

        //constructor
        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }

        public override void Eat()
        {
            base.Eat();//keeping the functionality of the base method
        }

        public override void MakeSound()
        {
            Console.WriteLine("Wuuuf!"); //overwriting the method
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
            else
            {
                Console.WriteLine($"{Name} doesn't want to play");
            }

        }
    }
}
