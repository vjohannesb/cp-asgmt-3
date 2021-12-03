using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory.Factories
{
    internal static class FactoryFactory
    {
        internal static IAnimalFactory GetFactory(string type)
        {
            type = type.ToLower();
            if (type == "dog")
                return new DogFactory();
            else if (type == "cat")
                return new CatFactory();
            else throw new NotImplementedException("Factory can only create DogFactory or CatFactory.");
        }
    }
}
