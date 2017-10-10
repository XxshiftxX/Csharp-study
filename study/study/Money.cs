using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study
{
    public class Currency
    {
        decimal money;
        public decimal Money
        {
            get { return money; }
        }

        public Currency(decimal money)
        {
            this.money = money;
        }
    }

    public class Won : Currency
    {
        public Won(decimal money) : base(money) { }

        public override string ToString()
        {
            return Money + "Won";
        }
    }

    public class Dollar : Currency
    {
        public Dollar(decimal money) : base(money) { }

        public override string ToString()
        {
            return Money + "Dollar";
        }

        static public explicit operator Won(Dollar dol)
        {
            return new Won(dol.Money * 1000);
        }
    }

    public class Yen : Currency
    {
        public Yen(decimal money) : base(money) { }

        public override string ToString()
        {
            return Money + "Yen";
        }

        static public implicit operator Won(Yen yen)
        {
            return new Won(yen.Money * 100);
        }
    }

    public class Program
    {
        public static void Main()
        {
            Won w = new Won(5000);
            Dollar d = new Dollar(2);
            Yen y = new Yen(30);

            w = y;
            Console.WriteLine(w.ToString());

            w = (Won)d;
            //w = d;    explicit은 암시적 형변환 불가
            Console.WriteLine(w.ToString());
        }
    }
}
