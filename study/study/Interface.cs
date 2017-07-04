using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study
{
    class Computer
    {
    }

    interface IMonitor
    {
        void TurnOn();
    }

    interface IKeyboard { }

    class Notebook : Computer, IMonitor, IKeyboard
    {
        public void TurnOn()
        {
            Console.WriteLine("TurnOn!");
        }
    }

    class Desktop : Computer, IMonitor, IKeyboard
    {
        public void TurnOn()
        {
            Console.WriteLine("Desktop Computer Booted!");
        }
    }

    class Program
    {
        static void Main()
        {
            Notebook n = new Notebook();
            n.TurnOn();
            IMonitor i = n;
            i.TurnOn();
            IMonitor i2 = new Desktop();
            i2.TurnOn();
        }
    }
}
