using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class PersonP
    {
        protected int Age;
        public void Greet()
        {
            Console.Write("Hello, ");
        }
        public void SetAge(int age)
        {
            Age = age;
        }

    }
    class Student : PersonP
    {
        public void Study()
        {
            Console.Write("I'm studying");
        }
        public void ShowAge()
        {
            Console.Write("My age is: " + Age );
        }
    }
    class Teacher : PersonP
    {
        public void Explain()
        {
            Console.Write("I'm explaining");
        }
    }

    internal class StudemtProfessorTest
    {
        public static void MainP()
        {
            PersonP person = new PersonP();
            Console.WriteLine("Person - ");
            person.Greet();
            Console.WriteLine("\n");

            Student student = new Student();
            Console.WriteLine("Student - ");
            student.SetAge(5);
            student.Greet();
            student.ShowAge();
            Console.WriteLine("\n");

            Teacher teacher = new Teacher();
            Console.WriteLine("Teacher - ");
            teacher.SetAge(25);
            teacher.Greet();
            teacher.Explain();
            Console.WriteLine("\n");
        }
    }
}
