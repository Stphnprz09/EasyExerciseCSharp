namespace OrderOfPriority;
class Program
{
    static void Main(string[] args)
    {
        //Create a C# program that requests an integer x from the user and print the result of the following operations:
        //-6 + x * 5
        //(13 - 2) * x
        //(x + -2) * (20 / 10)
        //(12 + x) / (5 - 4)

        Console.Write("Enter a number: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(-6 + x * 5);
        Console.WriteLine((13 - 2) * x);
        Console.WriteLine((x + -2) * (20 / 10));
        Console.WriteLine((12 + x) / (5 - 4));


    }
}

