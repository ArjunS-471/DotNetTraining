using System.Collections;

namespace Day10
{
    internal class Program
    {
        static void MainC(string[] args)
        {
            ArrayList al = new ArrayList();
            string str = "Arjun Sudarsanan";
            int x = 7;
            DateTime d = DateTime.Parse("03-08-2024");

            al.Add(str);
            al.Add(x);
            al.Add(d);

            foreach(var item in al)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=================HASHTABLE========================");

            Hashtable ht = new Hashtable();
            ht.Add("ora", "Oracle");
            ht.Add("vb", "VB.net");
            ht.Add("cs", "CS.net");
            ht.Add("asp", "asp.net");

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("================SORTEDLIST========================");

            SortedList sl = new SortedList();
            sl.Add("ora", "Oracle");
            sl.Add("vb", "VB.net");
            sl.Add("cs", "CS.net");
            sl.Add("asp", "asp.net");

            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("=================STACK=========================");

            Stack stk = new Stack();
            stk.Push("Oracle");
            stk.Push("VB.net");
            stk.Push("CS.net");
            stk.Push("asp.net");

            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=================QUEUE=========================");

            Queue q = new Queue();
            q.Enqueue("Oracle");
            q.Enqueue("VB.net");
            q.Enqueue("CS.net");
            q.Enqueue("asp.net");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

        }
    }
}