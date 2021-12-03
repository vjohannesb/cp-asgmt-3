using Assignment2.AbstractFactory.Animals;

namespace Assignment2.AbstractFactory.Factories
{
    internal class CatFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string name)
        {
            return new Cat(name);
        }
    }
}