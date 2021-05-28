using System;
namespace MyNamespace
{
    public class Primenumber
    {
        public static void Main(string[] args)
        {
            int condition= 0;
            bool result= true;
            Console.WriteLine("Welcome to the Prime Number Calculator");
            do{
            Console.Write("\nEnter the number:");
            int number = int.Parse(Console.ReadLine());
            if (number == 0 || number == 1)
            {
                Console.WriteLine("{0} is neither prime nor composite number", number);
            }
            else
            {
                prime_number(number);
            }
            Console.Write("\nIf you want to continue press '1' else '0': ");
            condition = Convert.ToInt16(Console.ReadLine());
            if(condition == 0){
                result = false;
            }
            else{
                result = true;
            }
            }while(result);
            Console.Write("\nThank You!");
        }
        static void prime_number(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                int a = number % i;
                if (a == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.WriteLine("{0} is a Prime Number",number);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number",number);
            }
        }
    }
}