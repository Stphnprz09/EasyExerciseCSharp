namespace ReverseChar;
class Program
{
    static void Main(string[] args)
    {
        //Write a program to ask the user for three letters and display them in reverse order.

        Console.WriteLine("Enter a 3 Character: ");
        char a = Convert.ToChar(Console.ReadLine());
        char b = Convert.ToChar(Console.ReadLine());
        char c = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("{0} {1} {2}", c, b, a);
    }
}

