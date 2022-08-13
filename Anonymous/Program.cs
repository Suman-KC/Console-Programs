using System;

public delegate void Test();

public class Program
{
    static int Main()
    {
        Test Display = delegate ()
        {
            Console.WriteLine("Anonymous Delegate method");
        };

        Display();
        return 0;
    }
}