using System;

namespace Lesson07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ Average class grades: ------------------");
            Student s1 = new Student(90);
            Console.WriteLine(Student.GetTotalGrade());

            Student s2 = new Student(100);
            Console.WriteLine(Student.GetTotalGrade());

            Student s3 = new Student(70);
            Console.WriteLine(Student.GetTotalGrade());

            Student s4 = new Student(88);
            Console.WriteLine(Student.GetTotalGrade());

            s4.Grade = 10;
            Console.WriteLine(Student.GetTotalGrade());

            Console.ReadKey();
        }

        
    }
}
