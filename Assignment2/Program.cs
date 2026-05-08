using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            num1 = 25;
            num2 = 63;
            num3 = 10;
            if (num1 > num2 && num1 > num3)
                Console.WriteLine("First number is largest");
            if (num2 > num1 && num2 > num3)
                Console.WriteLine("Second number is largest");
            if (num3 > num1 && num3 > num2)
                Console.WriteLine("Third number is largest");
        }
    }
}
