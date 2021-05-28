using System;
namespace MyNameSpace
{
    class odd_even_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd or Even number Calculator");
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            odd_even(number);
        }
        static void odd_even(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("The Entered Number is an Even Number");
            }
            else
            {
                Console.WriteLine("The Entered Number is an Odd Number");
            }
        }
    }
}