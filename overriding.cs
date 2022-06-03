using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }
    internal class Dog : Animal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }

        public static void Main(string[] args)
        {
            Animal puppy = new Dog();
            puppy.Eat();
            Console.ReadLine();
        }
    }
}


    
