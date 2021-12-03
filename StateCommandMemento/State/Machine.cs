using Assignment2.StateCommandMemento.Command;
using Assignment2.StateCommandMemento.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.State
{
    internal class Machine
    {
        public Machine()
        {
            State = new MachineStateOff();
            Commands = new();
        }

        public IMachineState State { get; set; }

        public List<ICommand> Commands { get; set; }

        public void SwitchState()
        {
            if (State is MachineStateOn)
                State = new MachineStateOff();
            else
            {
                State = new MachineStateOn();
                if (Commands.Count > 0)
                {
                    Console.WriteLine("\n[Running saved commands]");
                    foreach (var command in Commands)
                        command.Execute();
                    Commands = new();

                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);
                }
            }
        }

        public void PrintStatus()
        {
            var state = State is MachineStateOn ? "ON " : "OFF";
            Console.WriteLine($"[MACHINE IS {state}]");
            Console.WriteLine($"[{Commands.Count} COMMANDS WAITING]");
        }

        public MachineMemento CreateMemento()
        {
            return new MachineMemento(this);
        }
    }
}
