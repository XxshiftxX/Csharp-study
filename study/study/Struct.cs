using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study
{
    struct Vector
    {
        public int X;
        public int Y;

        public Vector(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return X + "," + Y;
        }
    }

    class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return X + "," + Y;
        }
    }

    class Study
    {
        public static void Main()
        {
            /*
            Vector v1 = new Vector();
            Vector v2;
            Vector v3 = new Vector(5, 10);

            Console.WriteLine(v3.ToString());

            v2.X = 4;
            v2.Y = 9;

            Console.WriteLine(v2.ToString());

            Point p1 = new Point(0, 0);

            Console.WriteLine("\n");

            Console.WriteLine(p1.ToString() + " | " + v1.ToString());

            v2 = v1;
            Point p2 = p1;

            Console.WriteLine(p2.ToString() + " | " + v2.ToString());

            p1.X = 100;
            v1.X = 100;

            Console.WriteLine(p2.ToString() + " | " + v2.ToString());
            */


            /*
            Vector v1 = new Vector(2, 5);

            Change(ref v1);

            Console.WriteLine(v1.ToString());
            */

            int rlt, rlt2;
            Divide(6, 2, out rlt);
            Divide(6, 0, out rlt2);

            Console.WriteLine(Divide(6, 2, out rlt) + " | " + Divide(6, 0, out rlt));
            Console.WriteLine(rlt + " | " + rlt2);
        }
    

        static void Change(ref Vector vt)
        {
            vt.X = 7;
            vt.Y = 3;
        }

        static bool Divide(int n1, int n2, out int result)
        {
            if(n2 == 0)
            {
                result = 0;
                return false;
            }

            result = n1 / n2;
            return true;
        }
    }
}
