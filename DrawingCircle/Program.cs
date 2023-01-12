using System;

namespace DrawingCircle
{
    class Program
    {
        //Drawing a Circle
        static void DrawingCircle(int n)
        {

        for (int y = -n; y <= n; y++)
        {
            for (int x = -n; x <= n; x++)
            {
                if (x * x + y * y <= n * n)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        }
        static void Main(string[] args)
        {
           Console.WriteLine("Enter a radius :");
           int n = int.Parse(Console.ReadLine());
           DrawingCircle(n);
        }
    }
}
