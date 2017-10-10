using System;

delegate int GetResultDelegate();

class Target
{
	public void Do(GetResultDelegate getResult)
    {
        Console.WriteLine(getResult());
    }
}

class Source
{
    public int GetResult()
    {
        return 10;
    }

    public void Test()
    {
        Target target = new Target();
        target.Do(new GetResultDelegate(this.GetResult));
    }
}

public class main
{
    public static void Main()
    {
        new Source().Test();
    }
}