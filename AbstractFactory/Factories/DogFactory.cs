using Assignment2.AbstractFactory.Animals;

namespace Assignment2.AbstractFactory.Factories
{
    internal class DogFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string name)
        {
            return new Dog(name);
        }
    }
}