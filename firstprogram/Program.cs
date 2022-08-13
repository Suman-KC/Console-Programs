using System;

namespace firstprogram
{
    class program
    {
        class name
        {
            public name()
            {
                Console.Write("My name is Ram");
            }
            public int sum;
            public name(int a, int b)
            {

                sum = a + b;
            }
        }
        class Program
        {

            static void Main(string[] args)
            {
                name S = new name();
                Console.WriteLine("Hello World!");
                name b = new name(2, 3);
                Console.WriteLine("the value of sum is{0}", b.sum);





            }
        }
    }
}
