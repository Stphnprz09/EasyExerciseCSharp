namespace DivisionAndDivisionModule;
class Program
{
    static void Main(string[] args)
    {
        //Write a program in C# that requests two integers from the user (x, y) and print the result of the division and the rest of the division on a new line.

        Console.WriteLine("Enter first number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(x / y);
        Console.WriteLine(x % y);

    }
}

