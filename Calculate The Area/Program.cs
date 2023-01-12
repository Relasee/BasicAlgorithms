using System;

namespace Calculate_The_Area
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Select a shape : ");
            string shape =Console.ReadLine();

            if(shape.ToLower()=="triangle"){
                Console.WriteLine("Select the calculate:");
                string calc = Console.ReadLine();
                if(calc.ToLower()=="perimeter")
                {
                    Console.WriteLine("Enter the a side :");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the b side :");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the c side :");
                    double c = double.Parse(Console.ReadLine());
                    double result = a + b + c;
                    Console.WriteLine("Result is : "+result);
                }
            
                else if(calc.ToLower()=="area")
                {
                    Console.WriteLine("Enter the a side :");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the h :");
                    double h = double.Parse(Console.ReadLine());
                    double result = (a*h)/2;
                    Console.WriteLine("Result is : "+result);
                }
                else{
                    Console.WriteLine("Wrong choice !");
                }

            }
            else if(shape.ToLower()=="rectangle")
            {
                Console.WriteLine("Select the calculate:");
                string calc = Console.ReadLine();
                if(calc.ToLower()=="perimeter")
                {
                    Console.WriteLine("Enter the a side :");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the b side :");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the c side :");
                    double c = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the d side :");
                    double d = double.Parse(Console.ReadLine());
                    double result = a + b + c + d;
                    Console.WriteLine("Result is : "+result);
                    
                }
                else if(calc.ToLower()=="area")
                {
                    Console.WriteLine("Enter the a side :");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the b side :");
                    double b = double.Parse(Console.ReadLine());
                    double result = a * b ;
                    Console.WriteLine("Result is : "+result);
                }
                else{
                    Console.WriteLine("Wrong choice !");
                }
            }
            else{
                Console.WriteLine("Wroing Choice! (select rectangle or triangle)");
            }
            
        }
    }
}
