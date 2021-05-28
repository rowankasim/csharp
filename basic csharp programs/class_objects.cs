using System;
namespace MyNamespace
{
    public class student_id
    {
        public string name;
        public int roll_num;
        public string blood_grp;

    }
    public class class_objects
    {
        public static void Main(string[] args)
        {
            student_id student1 = new student_id();
            student1.name = "Rowan Kasim";
            student1.roll_num = 117;
            student1.blood_grp = "A+ve";
            Console.WriteLine("Name : {0}",student1.name);
            Console.WriteLine("Roll.No: {0}",student1.roll_num);
            Console.Write("Bloog Group: {0}",student1.blood_grp);
        }
    }
}