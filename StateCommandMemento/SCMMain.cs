using Assignment2.StateCommandMemento.Command;
using Assignment2.StateCommandMemento.Memento;
using Assignment2.StateCommandMemento.State;
using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * 
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och 
         * sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * 
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * 
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */
        public void Run()
        {
            Machine machine = new();
            MachineMemento memento = machine.CreateMemento();

            Console.WriteLine("Press any key to launch StateCommandMemento.");
            Console.ReadKey(true);

            while (true)
            {
                Console.Clear();
                machine.PrintStatus();
                PrintMenu();

                var userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case '1':
                        machine.SwitchState();
                        break;
                    case '2':
                        Console.Write("Command: ");

                        var commandInput = Console.ReadLine() ?? "null";
                        var command = new MessageCommand(commandInput);

                        if (machine.State is MachineStateOn)
                        {
                            command.Execute();
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey(true);
                        }
                        else machine.Commands.Add(command);
                        break;
                    case '3':
                        Console.WriteLine("Restoring machine.");
                        memento.Restore();
                        break;
                    case '0':
                        return;
                    default:
                        continue;
                }
            }
        }

        private static (int, int) PrintMenu()
        {
            Console.WriteLine("1. Turn machine on/off");
            Console.WriteLine("2. Enter command");
            Console.WriteLine("3. Reset");
            Console.WriteLine("0. Exit");

            return Console.GetCursorPosition();
        }
    }
}