using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Vehicle
    {
        private string name;
        private string colour;

        public Vehicle(Vehicle vehicle) 
        { 
            name = vehicle.name; 
            colour = vehicle.colour;
        }

        public Vehicle(string name, string colour) 
        { 
            this.name = name;
            this.colour = colour;
        }

        public void PrintData()
        {
            Console.WriteLine("Model name - " + name + "\n colour - " + colour);
        }
    }
    internal class CopyConstructor
    {
        public static void MainC()
        {
            Vehicle v1 = new Vehicle("Bike", "Black");
            Vehicle v2 = new Vehicle(v1);
            v2.PrintData();
        }
        
    }
}
