using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternCommand
{
    public class ControlUnit
    {
        private List<Command> commands = new List<Command>();
        private int curren = 0;

        public void ExecuteCommand()
        {
            commands[curren].Execute();
            curren++;
        }

        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
                if (curren < commands.Count - 1)
                    commands[curren++].Execute();
        }
        public void StoreCommand(Command command) 
        { 
            commands.Add(command);
        }
        public void Undo(int levels) 
        { 
            for (int i = 0; i < levels; i++) 
            { 
                if (curren >0)
                    commands[--curren].UnExecute();
            }
        }
    }
}