namespace UsingWhile;
class Program
{
    static void Main(string[] args)
    {
        //Create a program in C# that requests a number (x) and displays 10*x. Must be repeated until the user enters 0.
        int x = Convert.ToInt32(Console.ReadLine());
        while (x != 0){
            Console.WriteLine(x * 10);
            x = Convert.ToInt32(Console.ReadLine());
        }
    }
}

