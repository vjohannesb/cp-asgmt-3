using Assignment2.AbstractFactory.Animals;
using Assignment2.AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den
        // ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på en sträng parameter
        
        public void Run()
        {
            IAnimalFactory dogFactory = FactoryFactory.GetFactory("Dog");
            IAnimalFactory catFactory = FactoryFactory.GetFactory("Cat");

            IAnimal dog = dogFactory.CreateAnimal("Doggo");
            IAnimal cat = catFactory.CreateAnimal("Catto");

            dog.SaySomething();
            cat.SaySomething();

            Console.Write("Enter 'dog' or 'cat' to create new animal: ");
            var userInput = Console.ReadLine().ToLower();

            IAnimalFactory userFactory;
            if (userInput == "dog")
                userFactory = FactoryFactory.GetFactory("Dog");
            else if (userInput == "cat")
                userFactory = FactoryFactory.GetFactory("Cat");
            else
            {
                Console.WriteLine("This is why we can't have nice things...");
                return;
            }

            Console.WriteLine("Enter name: ");
            userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("This is why we can't have nice things...");
                return;
            }

            var userAnimal = userFactory.CreateAnimal(userInput);
            userAnimal.SaySomething();

        }
    }
}
