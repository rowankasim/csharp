using System;
namespace MyNamespace
{
    class passcode
    {
        static void Main(string[] args)
        {
            bool condition;
            do
            {
                Console.Write("\nEnter your passcode: ");
                string passcode = Convert.ToString(Console.ReadLine());
                if (passcode == "Secret@007")
                {
                    Console.WriteLine("Your Passcode is Correct!");
                    condition = Convert.ToBoolean(0);
                }
                else
                {
                    Console.WriteLine("Incorrect Passcode, Please Try Again.");
                    condition = Convert.ToBoolean(1);
                }
            } while (condition);
        }
    }
}