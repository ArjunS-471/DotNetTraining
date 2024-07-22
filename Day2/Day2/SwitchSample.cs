using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class SwitchSample
    {

        static void MainSwitch(string[] args)
        {
            int Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Console.WriteLine("You have choosen 1");
                    break;
                case 2:
                    Console.WriteLine("You have choosen 2");
                    break;
                default:
                    Console.WriteLine("You have given wrong input");
                    break;
            }



        }
    }
}
