namespace BasicCalculator;
class Program
{
    static void Main(string[] args)
    {
        //Write a program in C# that calculates the result of adding, subtracting, multiplying and dividing two numbers entered by the user.

        Console.Write("Enter First Number: ");
        float num1 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        float num2 = Convert.ToSingle(Console.ReadLine());

        //Formula
        float sum = num1 + num2;
        float diff = num1 - num2;
        float prod = num1 * num2;
        float quot = num1 / num2;
        float mod = num1 % num2;

        //Printing Value
        Console.WriteLine("\nAddition: " + sum);
        Console.WriteLine("Subtraction: " + diff);
        Console.WriteLine("Multiplication: " + prod);
        Console.WriteLine("Division: " + quot);
        Console.WriteLine("Modulus: " + mod);
    }
}

