using System;
namespace MyNamespace
{
    public class work_experience
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Years of Work Experience: ");
            int work_experience = int.Parse(Console.ReadLine());
            switch (work_experience)
            {
                case 0:
                    Console.WriteLine("Experience of Working - Fresher");
                    break;
                case 1:
                    Console.WriteLine("Experience of Working - Junior");
                    break;
                case 2:
                    Console.WriteLine("Experience of Working - Junior");
                    break;
                case 3:
                    Console.WriteLine("Experience of Working - Intermediate");
                    break;
                case 4:
                    Console.WriteLine("Experience of Working - Intermediate");
                    break;
                case 5:
                    Console.WriteLine("Experience of Working - Advanced");
                    break;
                default:
                    Console.WriteLine("Experience of Working - Senior");
                    break;

            }

        }
    }
}