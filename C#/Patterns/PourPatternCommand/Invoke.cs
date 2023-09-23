using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PourPatternCommand
{
    public class Invoke
    {
        private Command command;

        public void ExecuteCommand()
        {
            command.Execute();
        }


        internal void StoreCommand(Command command)
        {
            this.command = command;
        }
    }
}