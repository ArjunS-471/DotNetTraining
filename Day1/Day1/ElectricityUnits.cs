using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class ElectricityUnits
    {
        static void MainElec(string[] args)
        {
            Console.WriteLine("Input electricity unit charges - ");
            double Units = Convert.ToInt32(Console.ReadLine());

            double BillAmount = 0;

            if (Units > 250)
            {
                BillAmount = ((Units - 250) * 1.5) + (100 * 1.2) + (100 * 0.75) + (50 * 0.5);
            }
            else if (Units > 150 && Units <= 250)
            {
                BillAmount = ((Units - 150) * 1.2) + (100 * 0.75) + (50 * 0.5);
            }
            else if (Units > 50 && Units <= 150)
            {
                BillAmount = ((Units - 50) * 0.75) + (50 * 0.5);
            }
            else if (Units <= 50)
            {
                BillAmount = (Units * 0.5);
            }
            else
            {
                Console.WriteLine("Invalid units entered");
            }
            //Surcharge
            BillAmount = BillAmount + (BillAmount * 0.20);
            Console.WriteLine(BillAmount);
        }
    }
}
