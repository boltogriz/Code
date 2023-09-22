using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternFacade
{
    public class Facade
    {
        public Facade()
        {
            SubSystem1 = new SubSystem1();
            SybSystem2 = new SybSystem2();
            SybSystem3 = new SybSystem3();
            SybSystem4 = new SybSystem4();
        }

        private SubSystem1 SubSystem1
        {
            get; set;
        }

        private SybSystem2 SybSystem2
        {
            get; set;
        }

        private SybSystem3 SybSystem3
        {
            get; set;
        }

        private SybSystem4 SybSystem4
        {
            get; set;
        }

        public void MethodA()
        {
           SubSystem1.MethodOne();
           SybSystem2.MethodTwo();
        }

        public void MethodB()
        {
            SybSystem3.MethodThree();
            SybSystem4.MethodFour();
        }
    }
}