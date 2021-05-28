using System;
namespace MyNamespace
{
    class datatypes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter a float number: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter any character: ");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nEnter a string: ");
            string d = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nEntered Integer Number is: " + a);
            Console.WriteLine("Entered Decimal number is: " + b);
            Console.WriteLine("Entered Character is: " + c);
            Console.WriteLine("Entered String is: " + d);
        }
    }
}