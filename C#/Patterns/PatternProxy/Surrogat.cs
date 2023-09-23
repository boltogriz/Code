using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternProxy
{
    public class Surrogat : IHuman
    {
        private IHuman operatorHuman;

        public Surrogat(IHuman operatorHuman)
        {
            this.operatorHuman = operatorHuman;
        }

        public override void Request()
        {
            this.operatorHuman.Request();
        }
    }
}