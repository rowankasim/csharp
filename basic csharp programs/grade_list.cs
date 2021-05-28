using System;
using System.Collections.Generic;
namespace MyNamespace
{
    public class grade_list
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome Exam Grade Generator");
            bool condition = true;
            var students_name = new List<string>();
            var students_marklist = new List<int>();
            var students_grade = new List<string>();
            int students_mark = 0;
            while (condition)
            {
                Console.Write("\nEnter Student Name: ");
                students_name.Add(Console.ReadLine());
                Console.Write("Enter Student Mark: ");
                students_mark = int.Parse(Console.ReadLine());
                students_marklist.Add(students_mark);
                students_grade.Add(grade_generator(students_mark));
                Console.WriteLine("Grade Point: {0}", (grade_generator(students_mark)));
                Console.Write("\nIf you want to Add more students press '1' else '0': ");
                int result = int.Parse(Console.ReadLine());
                if (result == 0)
                {
                    Console.WriteLine("\nDisplaying Student's Name, Marks and Grade List: ");
                    for (int i = 0; i < (students_name.Count); i++)
                    {
                        Console.WriteLine("\nName: {0}", students_name[i]);
                        Console.WriteLine("Marks: {0}", students_marklist[i]);
                        Console.WriteLine("Grade Point: {0}", students_grade[i]);
                    }
                    condition = false;
                }
                else
                {
                    condition = true;
                }
            }
        }

        static string grade_generator(int students_mark)
        {
            if (students_mark >= 90 && students_mark <= 100)
            {
                return "A+";
            }
            else if (students_mark >= 80 && students_mark < 90)
            {
                return "A";
            }
            else if (students_mark >= 70 && students_mark < 80)
            {
                return "B";
            }
            else if (students_mark >= 60 && students_mark < 70)
            {
                return "C";
            }
            else if (students_mark >= 50 && students_mark < 60)
            {
                return "D";
            }
            else if (students_mark > 100)
            {
                return "Invalid Input Marks";
            }
            else
            {
                return "Fail";
            }
        }
    }
}