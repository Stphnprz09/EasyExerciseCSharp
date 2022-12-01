using System;

namespace DivisionByZero;
class Program
{
    static void Main(string[] args)
    {
        //Create a C# program that asks the user for two numbers (x, y) and shows the result of their division.
        //You will have to control division by 0 with the use of the DivideByZeroException exception in a try-catch block.If the user tries to divide by 0, it Cannot be divided by 0.

        Console.Write("Enter first number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int y = Convert.ToInt32(Console.ReadLine());

        try
        {
            int quot = x / y;
            Console.WriteLine("Quotient: " + quot);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by 0");
        }
        }
}

