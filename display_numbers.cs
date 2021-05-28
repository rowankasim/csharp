using System;
namespace MyNamespace
{
    public class display_numbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number display system\n");
            Console.Write("Enter the Fist Number: ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Last Number: ");
            int last_number = Convert.ToInt32(Console.ReadLine());
            if (first_number < last_number)
            {
                Console.WriteLine("Displaying Numbers: ");
                while (first_number <= last_number)
                {
                    Console.WriteLine(first_number);
                    first_number++;
                }
            }
            else if (first_number > last_number || first_number == last_number)
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}