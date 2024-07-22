using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Loops
    {
        static void MainLoop(string[] args)
        {
            Console.WriteLine("\n" + "===================START==================");
            for (int index = 0; index < 10; index++)
            {
                Console.Write(index + " ");
            }

            Console.WriteLine("\n" + "==========================================");

            int doIndex = 0;
            do
            {
                Console.Write(doIndex + " ");
                doIndex++;
            } while (doIndex < 10);

            Console.WriteLine("\n" + "==========================================");
            int whileIndex = 0;
            while (whileIndex < 10)
            {
                Console.Write(whileIndex + " ");
                whileIndex++;
            }
            Console.WriteLine("\n" + "====================END===================");
        }
    }
}
