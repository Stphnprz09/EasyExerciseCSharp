namespace GenerateRandomNumber;
class Program
{
    static void Main(string[] args)
    {
        //Create a C# program that prompts the user for 2 integers and displays a random number on the screen between those values. You can use the .NET Random object.

        Console.Write("Enter 2 Numbers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        Random random = new Random();
        int number = random.Next(num1, num2 + 1);

        Console.WriteLine(number);
    }
}

