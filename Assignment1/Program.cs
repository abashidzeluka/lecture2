using System.Threading.Channels;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Age:");
            byte age = Convert.ToByte(Console.ReadLine());
            if (age >= 18)
                Console.WriteLine("Congratulation! You have the right to vote.");
             else
                Console.WriteLine("Unfortunetly you don't have the right to vote.");
        }
    }
}
