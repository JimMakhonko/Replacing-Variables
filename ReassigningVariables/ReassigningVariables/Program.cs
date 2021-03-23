using System;

namespace ReassigningVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 3;

            Console.WriteLine("First assign a = -a - b.");
            a = -a - b;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Console.WriteLine("Second assign b = -a - b.");
            b = -a - b;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Console.WriteLine("Third assign a = -a - b.");
            a = -a - b;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
