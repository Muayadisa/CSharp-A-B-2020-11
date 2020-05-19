using System;

namespace Lesson07
{
    class Student
    {
        // static properties:
        private static int sumGrade = 0;
        private static int NumOfStudents = 0; 

        // Properties:
        private int grade; // default - 0
        public int Grade
        {
            get { return grade; }
            set {
                if(value >= 0 && value <= 100)
                {
                    // Remove the previous grade, in case we change the value of student's grade:
                    sumGrade -= grade;

                    grade = value;
                    sumGrade += grade;
                }
            }
        }


        // constructor:
        public Student(int grade)
        {
            Grade = grade;
            NumOfStudents++;
        }

        // GetTotalGrade() - static method - for all the instances of the class: 
        public static string GetTotalGrade()
        {
            return $"The average grade of the {NumOfStudents} student is {sumGrade / NumOfStudents}";
        }
    }
}
