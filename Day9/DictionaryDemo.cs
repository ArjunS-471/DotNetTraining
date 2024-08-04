using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class DictionaryDemo
    {
        public static void MainD()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1, "Virat");
            myDictionary.Add(2, "Rohit");
            myDictionary.Add(3, "Sachin");
            /*
            foreach (KeyValuePair<int, string> item in myDictionary)
            */

            foreach (var item in myDictionary)
            {
                Console.WriteLine("Key - {0} , Value - {1}", item.Key, item.Value);
            }
            Console.WriteLine("==================================================================");
            Console.WriteLine("HashSet");
            HashSet<int> myset = new HashSet<int>();
            myset.Add(1);
            myset.Add(2);
            myset.Add(3);
            myset.Add(2);

            foreach(var item in myset)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==================================================================");
            Console.WriteLine("Queue");
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            
            while (myQueue.Count > 0)
            {
                Console.WriteLine(myQueue.Dequeue());
            }

            Console.WriteLine("==================================================================");
            Console.WriteLine("Stack");
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());
            }

        }
    }
}
