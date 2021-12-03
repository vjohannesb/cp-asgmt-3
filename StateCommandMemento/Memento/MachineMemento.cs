using Assignment2.StateCommandMemento.Command;
using Assignment2.StateCommandMemento.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Memento
{
    internal class MachineMemento
    {
        public Machine Machine { get; set; }

        public MachineMemento(Machine machine)
        {
            Machine = machine;
        }

        public void Restore()
        {
            Machine.State = new MachineStateOff();
            Machine.Commands = new();
        }
    }
}
