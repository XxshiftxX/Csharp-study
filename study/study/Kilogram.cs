using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study
{
    class Kilogram
    {
        double mass;

        public Kilogram(double value)
        {
            this.mass = value;
        }

        /*
        public Kilogram Add(Kilogram target)
        {
            return new Kilogram(this.mass + target.mass);
        }
        */

        public static Kilogram operator +(Kilogram op1, Kilogram op2)
        {
            return new Kilogram(op1.mass + op2.mass);
        }

        public override string ToString()
        {
            return mass + "kg";
        }
    }

    class SMath
    {
        int num;

        public SMath(int value)
        {
            this.num = value;
        }
        
        public static bool operator ==(SMath s1, SMath s2)
        {
            return (s1.num + s2.num) % 2 == 0;
        }

        public static bool operator !=(SMath s1, SMath s2)
        {
            return (s1.num + s2.num) % 2 != 0;
        }
    }

    class Program
    {
        public static void Main()
        {
            Kilogram kg1 = new Kilogram(5);
            Kilogram kg2 = new Kilogram(12);
            Kilogram kg3 = new Kilogram(30);

            /*
            kg1 = kg1.Add(kg2);
            */
            kg1 = kg1 + kg2;
            kg2 += kg1;
            Console.WriteLine(kg1.ToString());
            Console.WriteLine(kg2.ToString());

            Console.WriteLine("\n\n");

            SMath a = new SMath(3);
            SMath b = new SMath(4);
            SMath c = new SMath(5);

            Console.WriteLine(a == b);
            Console.WriteLine(a == c);
        }
    }
}
