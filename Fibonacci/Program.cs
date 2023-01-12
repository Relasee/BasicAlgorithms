using System;

namespace Fibonacci
{
    class Program
    {
         public static int Fibonacci(int n)
        {
            int fib1 = 0;
            int fib2 = 1;
            int fibonacci=1;
            for(int i=0;i<=n;i++)
            {
                fibonacci=fib1+fib2;
                fib1=fib2;
                fib2=fibonacci;
            }
            return fibonacci;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }
        
    }
}
