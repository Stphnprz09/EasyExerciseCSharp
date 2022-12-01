namespace Average;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 4 Numbers: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());
        int num4 = Convert.ToInt32(Console.ReadLine());

        int average = (num1 + num2 + num3 + num4) / 4;
        Console.WriteLine("Average: " + average);
    }
}

