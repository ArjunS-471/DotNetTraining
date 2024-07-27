using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class VehicleDemo
    {
        protected string name;

        public VehicleDemo()
        {
            name = "Honda";
        }
    }
    class Bike : VehicleDemo
    {
        public void Print()
        {
            Console.WriteLine(name);
        }
    }

    class Scooter : VehicleDemo
    {
        public void Print()
        {
            Console.WriteLine(name);
        }
    }

    internal class Inheritance
    {
        public static void MainI() 
        { 
            Bike b = new Bike();
            b.Print();

            Scooter s = new Scooter();
            s.Print();
        }
    }
}
