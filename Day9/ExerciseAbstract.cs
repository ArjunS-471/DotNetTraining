using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day9
{
    internal class ExerciseAbstract
    {
        public abstract class Animal
        {
            public string name;

            public void SetName(string Name)
            {
                this.name = Name;
            }

            public string GetName()
            {
                return name;
            }

            public abstract void Eat();
        }
        public class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("Eating");
            }
        }

        public static void Main()
        {
            Dog dog = new Dog();

            Console.WriteLine("Type in a name for Dog - ");
            string dogName = Console.ReadLine();
            dog.SetName(dogName);
            dogName = dog.GetName();
            Console.WriteLine(dogName);
            dog.Eat();
        }
    }
}
