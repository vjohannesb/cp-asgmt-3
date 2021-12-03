using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    internal class MessageCommand : ICommand
    {
        private DateTime _date;
        private string _message;

        public MessageCommand(string message)
        {
            _message = message;
            _date = DateTime.Now;
        }

        public void Execute()
        {
            Console.WriteLine($"[{_date}] {_message}");
        }

        public MessageCommand Clone()
        {
            return (MessageCommand)MemberwiseClone();
        }
    }
}
