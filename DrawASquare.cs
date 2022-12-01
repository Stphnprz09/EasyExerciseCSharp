namespace DrawASquare;
class Program
{
    static void Main(string[] args)
    {
        //Write a program in C# that asks for a number (x) and a width to show a square of that width.

        //Console.WriteLine("Enter 2 Numbers: ");
        //int num = Convert.ToInt32(Console.ReadLine());
        //int width = Convert.ToInt32(Console.ReadLine());

        //for(int row = 0; row < width; row++)
        //{
        //    for(int col = 0; col < width; col++)
        //    {
        //        Console.Write(num);

        //      Console.WriteLine();
        //    }
        //}
        int x = Convert.ToInt32(Console.ReadLine());
        int width = Convert.ToInt32(Console.ReadLine());

        for (int row = 0; row < width; row++)
        {
            for (int column = 0; column < width; column++)
                Console.Write(x);

            Console.WriteLine();
        }

    }
}

