using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{   
    class Person
    {
        private string Name;

        public Person(string name)
        {
            this.Name = name;
        }

        public static Person[] GetNames(Person[] PersonList) 
        {
            Console.WriteLine("Input");
            for (int i = 0; i < PersonList.Length; i++)
            {
                string name = Console.ReadLine();
                PersonList[i] = new Person(name);
            }
            return PersonList;
        }

        public static void PrintNames(Person[] PersonList)
        {
            Console.WriteLine("Ouput");
            for (int i = 0; i < PersonList.Length; i++)
            {
                Console.WriteLine("Hello! My name is " + PersonList[i].Name );
            }
        }

        ~Person()
        {
            Name = String.Empty;
            Console.WriteLine("destructor executed");
        }

        public override string ToString()
        {
            return "Hello"; 
        }
    }

    
    internal class ProblemConstructors
    {
        
        public static void MainP()
        {
            Person[] person = new Person[3];
            person = Person.GetNames(person);
            Person.PrintNames(person);
            Console.WriteLine(person.ToString());
        }

        
    }
}
