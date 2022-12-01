namespace EasyCSharpExercises;
class Program
{
    static void Main(string[] args)
    {
        //Write a C# program that requests a number (x) and answers if it is positive or negative.

        Console.Write("Enter a Number: ");
        int x = Convert.ToInt32(Console.ReadLine());

        if (x > 0)
        {
            Console.WriteLine("Positive");
        }
        else
        {
            Console.WriteLine("Negative");
        }
    }
}

