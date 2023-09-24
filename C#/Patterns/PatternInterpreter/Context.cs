using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternInterpreter
{
    public class Context
    {
        public string Source { get; set; }
        public char Vocabulary { get; set; }
        public bool Result { get; set; }
        public int Position { get; set; }
    }
}