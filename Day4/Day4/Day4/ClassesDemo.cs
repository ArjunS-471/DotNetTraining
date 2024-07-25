using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class ClassesDemo
    {

        class Student
        {
            public int RollNo;
            public String Name;
            public String StudentClass;
            public String Gender;

            public void PrintDate(Student student)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine(student.RollNo);
                Console.WriteLine(student.StudentClass);
                Console.WriteLine(student.Gender);
            }
        }

        internal class Classesdemo
        {
            public static void MainDemo()
            {
                Student student = new Student();
                student.RollNo = 101;
                student.Name = "Arjun Sudarsanan";
                student.StudentClass = "X";
                student.Gender = "Male";

                student.PrintDate(student);

            }
        }
        
        
    }
}
