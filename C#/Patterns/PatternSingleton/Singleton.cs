using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternSingleton
{
    public class Singleton
    {
        static Singleton instance;
        string singletonData = string.Empty;
        protected Singleton()
        {
            
        }

        public static Singleton Instance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
        public void SingletonOperation() 
        {
            singletonData = "SingletonData";
        }
        public string GetSingletonData()
        {
            return singletonData;
        }
    }
}