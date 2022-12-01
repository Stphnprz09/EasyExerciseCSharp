namespace BsaicCalculationUsingSwich;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 2 Numbers: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Operation: [+],[-],[*],[/] ");
        char operation = Convert.ToChar(Console.ReadLine());

        switch (operation)
        {
            case '+':
                Console.WriteLine("{0}+{1}={2}", num1, num2, num1 + num2);
                break;
            case '-':
                Console.WriteLine("{0}-{1}={2}", num1, num2, num1 - num2);
                break;
            case '*':
                Console.WriteLine("{0}*{1}={2}", num1, num2, num1 * num2);
                break;
            case '/':
                Console.WriteLine("{0}/{1}={2}", num1, num2, num1 / num2);
                break;
            default:
                Console.WriteLine("Unrecognized Number: ");
                break;
        }
    }
}

