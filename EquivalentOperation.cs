namespace EquivalentOperation;
class Program
{
    static void Main(string[] args)
    {
        //Write a C# program to ask the user for three numbers (a, b, c) and display the result of (a+b)*c and the result of a * c + b*c.

        Console.WriteLine("Enter 3 Numbers: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine((a+b)*c);
        Console.WriteLine(a * c + b * c);
    }
}

