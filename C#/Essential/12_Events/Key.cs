using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Events
{
    public delegate void PressKeyEventHandler();
    internal class Key
    {
        public event PressKeyEventHandler PressKeyA = null;
        public event PressKeyEventHandler PressKeyB = null;
        public event PressKeyEventHandler PressKeyC = null;
        public void PressKeyAEvent()
        {
            if (PressKeyA != null)
            {
                PressKeyA.Invoke();
            }
        }
        public void PressKeyBEvent()
        {
            if (PressKeyB != null)
            {
                PressKeyB.Invoke();
            }
        }
        public void PressKeyCEvent()
        {
            if (PressKeyC != null)
            {
                PressKeyC.Invoke();
            }
        }
        public void Start()
        {
            Console.WriteLine("Для выхода нажмите z");
            while (true)
            {
                string s = Console.ReadKey().KeyChar.ToString();
                switch (s)
                {
                    case "a":
                    case "A":
                        PressKeyAEvent();
                        break;
                    case "b":
                    case "B":
                        PressKeyBEvent();
                        break;
                    case "c":
                    case "C":
                        PressKeyCEvent();
                        break;
                    case "z":
                    goto Exit;
                    default:
                        Console.WriteLine($" - Нет оброботчика для кнопки {s}");
                        break;
                }
            }
        Exit:;
        }
    }
}
