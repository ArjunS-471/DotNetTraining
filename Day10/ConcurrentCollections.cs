using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class ConcurrentCollections
    {
        public static void MainCC()
        {
            Console.WriteLine("=================Concurrent Stack===========================");

            BlockingCollection<int> blockingCollection = new BlockingCollection<int>();

            blockingCollection.Add(10);
            blockingCollection.Add(20);
            blockingCollection.Add(30);
            blockingCollection.Add(40);
            blockingCollection.Add(50);
            blockingCollection.Add(60);
            blockingCollection.Add(70);
            blockingCollection.Add(80);
            blockingCollection.Add(90);

            if (blockingCollection.TryAdd(100, TimeSpan.FromSeconds(1))) 
            {
                Console.WriteLine("Item added");
            }
            else 
            {
                Console.WriteLine("item is not added");
            }

            foreach( var item in  blockingCollection )
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("=================Concurrent Stack===========================");

            ConcurrentStack<int> stackCollection = new ConcurrentStack<int>();

            stackCollection.Push(10);
            stackCollection.Push(20);

            foreach (var item in stackCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
