namespace RangeOfNumbers;
class Program
{
    static void Main(string[] args)
    {
        //Create a C# program that requests a range of numbers from the user (x, y) and displays them on the screen.

        Console.WriteLine("Enter 2 Numbers: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        for(int i = x; x <= y; x++)
        {
            Console.Write(x);
        }

    }
}

