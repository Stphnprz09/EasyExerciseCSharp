namespace SumSquared;
class Program
{
    static void Main(string[] args)
    {
        //Write a program in C# that requests an integer x from the user and print the result of adding it to the square.

        Console.Write("Enter a Number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        //formula
        int sqrd = num * num;

        //Printing result
        Console.WriteLine("Squared: " + sqrd);
    }
}

