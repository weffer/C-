using System;

class Program
{
    static void Main()
    {
        Test();
    }

    static void Test()
    {
        Bar(0);
    }

    static void Bar(int x)
    {
        Console.WriteLine(1 / x);
    }
}
