using System;

namespace Program
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			MethodOverride m = new MethodOverride();
			Base b = new Base();

			b.Base_main();
		}
	}

	// 4.4.1 Method Override
	public class MethodOverride
	{
		public void MethodOverride_Main()
		{
			Mammal m = new Mammal();
			Lion l = new Lion();
			Whale w = new Whale();
			Human h = new Human();

			m.Move();
			l.Move();
			w.Move();
			h.Move();
			Console.WriteLine();

			Mammal reType = l;
			reType.Move();
		}
	}
	class Mammal
	{
		virtual public void Move()
		{
			Console.WriteLine("이동한다.");
		}
	}

	class Lion : Mammal
	{
		override public void Move()
		{
			Console.WriteLine("네 발로 움직인다.");
		}
	}

	class Whale : Mammal
	{
		override public void Move()
		{
			Console.WriteLine("수영한다.");
		}
	}

	class Human : Mammal
	{
		override public void Move()
		{
			Console.WriteLine("두 발로 움직인다.");
		}
	}

	public class Base
	{
		public void Base_main()
		{
			Computer c = new Computer();
			Notebook n = new Notebook();

			c.Boot();
			n.Boot();
		}
	}
	// 4.4.1.1 Method reuse with base
	public class Computer
	{
		virtual public void Boot()
		{
			Console.WriteLine("메인보드 켜기");
		}
	}

	public class Notebook : Computer
	{
		override public void Boot()
		{
			base.Boot();
			Console.WriteLine("액정 화면 켜기");
		}
	}
}
