using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study
{
    class Mathematics
    {
        public int GetAreaOfSquare(int x)
        {
            return x * x;
        }

        public int GetValue()
        {
            return 10;
        }

        public void Output(string prefix, int value)
        {
            Console.WriteLine(prefix + value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            int result = m.GetAreaOfSquare(m.GetValue());
            m.Output("결과 : ", result);
        }
    }
}
