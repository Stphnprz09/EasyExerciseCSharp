namespace BasicCalculatorUsingIf;
class Program
{
    static void Main(string[] args)
    {
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //char operation = (char)Console.Read();
        ////int num2 = Convert.ToInt32(Console.ReadLine());
        //int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2 Numbers: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Operation: [+],[-],[*],[/] ");
        char operation = Convert.ToChar(Console.ReadLine());

        if(operation == '+')
        {
            Console.WriteLine("{0}+{1}={2}",num1, num2,num1+num2);
            // can be also like this
            //int sum = num1 + num2;
            //Console.WriteLine(sum);
        }else if (operation == '-')
        {
            Console.WriteLine("{0}-{1}={2}", num1, num2, num1 - num2);
        }else if(operation == '*')
        {
            Console.WriteLine("{0}*{1}={2}", num1, num2, num1 * num2);
        }else if(operation == '/')
        {
            Console.WriteLine("{0}/{1}={2}", num1, num2, num1 / num2);
        }
        else
        {
            Console.WriteLine("Number unrecognized");
        }

    }
}

