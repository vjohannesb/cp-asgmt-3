using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory.Animals
{
    class Dog : IAnimal
    {
        public Dog(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void SaySomething()
        {
            Console.WriteLine($"{Name} says 'woff'!");
        }
    }
}
