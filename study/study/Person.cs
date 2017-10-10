using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("시프트");
            p.WriteName();
        }
    }

    class Person
    {
        string _name;

        public Person(string name)
        {
            _name = name;
            Console.WriteLine("생성자 호출");
        }

        public void WriteName()
        {
            Console.WriteLine("Name: " + _name);
        }
    }
}
