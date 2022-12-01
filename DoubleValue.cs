using System.ComponentModel;

namespace DoubleValue;
class Program
{
    static void Main(string[] args)
    {
        //Write a C# program that requests the width (x) and height (y) of a rectangle and calculate the perimeter, area and diagonal.
        //Perimeter = sum of the four sides.
        //Area = base x height.
        //Diagonal = Pythagorean theorem.

        Console.Write("Enter x: ");
        double x = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = Convert.ToSingle(Console.ReadLine());

        //formula
        double perimeter = x * 2 + y * 2;
        double area = x * y;
       double diagonal = Math.Sqrt(x * x + y * y);

        //Printing Value
        Console.WriteLine("Perimeter: " + perimeter);
        Console.WriteLine("Area: " + area);
        Console.WriteLine("Diagonal: " + diagonal);
    }
}

