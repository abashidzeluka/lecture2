using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 > num2 && num1 > num3)
                Console.WriteLine("The first number is the largest");
            if (num2 > num1 && num2 > num3)
                Console.WriteLine("The second number is the largest");
            if (num3 > num1 && num3 > num2)
                Console.WriteLine("The third number is the largest");

        }
    }
}
