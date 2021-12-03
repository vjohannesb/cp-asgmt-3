using Assignment2.AbstractFactory.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory.Factories
{
    public interface IAnimalFactory
    {
        public IAnimal CreateAnimal(string name);
    }
}
