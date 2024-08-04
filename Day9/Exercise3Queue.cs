using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Exercise3Queue
    {
        public static void MainQ()
        {
            Queue<string> myQueue = new Queue<string>();
            
            //Queue add
            myQueue.Enqueue("Run");
            myQueue.Enqueue("Jump");
            myQueue.Enqueue("Leap");
            myQueue.Enqueue("Eat");
            myQueue.Enqueue("Sleep");

            //Queue display
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }

            //Queue dequeue
            string dequeuedTask = myQueue.Dequeue();
            Console.WriteLine("Dequeue task - " + dequeuedTask);
            
            //Queue peek
            string peekTask = myQueue.Peek();
            Console.WriteLine("Peek task - " + peekTask);

            //Queue count
            Console.WriteLine(myQueue.Count);

            //Queue display again for validation
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }
        }
    }
}