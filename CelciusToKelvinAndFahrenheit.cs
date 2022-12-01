namespace CelciusToKelvinAndFahrenheit;
class Program
{
    static void Main(string[] args)
    {
        //Create a C# program to convert from degrees Celsius to Kelvin and Fahrenheit. Request the user the number of degrees celsius to convert them using the following conversion tables:
        //kelvin = celsius + 273
        //fahrenheit = celsius x 18 / 10 + 32

        Console.Write("Enter a Celcius: ");
        int celcius = Convert.ToInt32(Console.ReadLine());

        //Formula
        int kelvin = celcius + 273;
        int fahren = celcius * 18 / 10 + 32;

        //Printing Value
        Console.WriteLine("Kelvin: " + kelvin);
        Console.WriteLine("Fahrenheit: " + fahren);

    }
}

