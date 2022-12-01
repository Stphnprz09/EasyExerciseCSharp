namespace GreatestOfThreeNumbers;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a 3 Numbers: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine(num1);
        }else if(num2>num1 && num2 > num3)
        {
            Console.WriteLine(num2);
        }else if(num3>num1 && num3 > num2)
        {
            Console.WriteLine(num3);
        }
        else
        {
            Console.WriteLine("Equal");
        }
       
    }
}

