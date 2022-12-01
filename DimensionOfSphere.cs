namespace EasyExerciseCSharp;
class Program
{
    static void Main(string[] args)
    {
        //Create a program in C# for calculate the surface and volume of a sphere, given its radius.
        //surface = 4 * pi * radius squared
        //volume = 4 / 3 * pi * radius cubed

        Console.Write("Enter radius: ");
        float radius = Convert.ToSingle(Console.ReadLine());

        float pi = 3.14159f;

        //Formula
        float surface = 4 * pi * (radius * radius);
        float volume = 4 / 3 * pi * (radius * radius * radius);

        //Print value
        Console.WriteLine("Surface: " + surface);
        Console.WriteLine("Volume: " + volume);
    }
}

