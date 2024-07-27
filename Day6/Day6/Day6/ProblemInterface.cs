using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    interface IVehiculo
    {
        public void Drive();
        public bool Refuel(int amountGas);

    }
 
    class Car : IVehiculo
    {
        private int Gasoline;

        public Car (int initGas)
        {
            Gasoline = initGas;
        }

        public void Drive()
        {
            if (Gasoline > 0)
            {
                Console.WriteLine("Car is driving");
            } else
            {
                Console.WriteLine("No gasoline");
            }
        }

        public bool Refuel(int amountGas)
        {
            if (amountGas > 0)
            {
                Gasoline += amountGas;
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
    

    internal class ProblemInterface
    {
        public static void Main()
        {
            Car c = new Car(0);
            Console.WriteLine("Enter gas to be refuelled - ");
            int GasAmount = Convert.ToInt32(Console.ReadLine());

            c.Refuel(GasAmount);
            c.Drive();
        }
    }
}
