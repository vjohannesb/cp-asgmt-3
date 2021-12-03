using Assignment2.AbstractFactory;
using Assignment2.Adapter;
using Assignment2.Facade;
using Assignment2.StateCommandMemento;

using System;

namespace Assignment2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory");
            AbstractFactoryMain abstractFactory = new();
            abstractFactory.Run();
            Console.WriteLine();

            Console.WriteLine("Facade");
            FacadeMain facadeMain = new();
            facadeMain.Run();
            Console.WriteLine();

            Console.WriteLine("Adapter");
            AdapterMain adapterMain = new();
            adapterMain.Run();
            Console.WriteLine();

            Console.WriteLine("State Command Memento");
            SCMMain scmMain = new();
            scmMain.Run();
        }
    }
}