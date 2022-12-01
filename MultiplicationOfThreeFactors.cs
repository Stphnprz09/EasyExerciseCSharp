namespace MultiplicationOfThreeFactors;
class Program
{
    static void Main(string[] args)
    {
        //Write a program in C# that multiplies by three factors. Ask the user for three numbers and show the result of multiplying them.

        Console.WriteLine("Enter a Numbers: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        //formula
        int multi = num1 * num2 * num3;

        //Printing Result
        Console.WriteLine("Answer: " + multi);
    }
}

