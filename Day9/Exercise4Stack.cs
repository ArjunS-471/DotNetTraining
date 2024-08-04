using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Exercise4Stack
    {
        public static void MainS()
        {
            Stack<string> stackBooks = new Stack<string>();
            
            //Stack add
            stackBooks.Push("Harry Potter 1");
            stackBooks.Push("Harry Potter 2");
            stackBooks.Push("Harry Potter 3");
            stackBooks.Push("Harry Potter 4");
            stackBooks.Push("Harry Potter 5");

            //Stack display
            foreach (var book in stackBooks)
            {
                Console.WriteLine(book);
            }

            //Stack pop
            string popBook = stackBooks.Pop();
            Console.WriteLine("Pop item - " + popBook);

            //Stack peek
            string peekBook = stackBooks.Peek();
            Console.WriteLine("Peek item - " + peekBook);

            //Stack count
            Console.WriteLine("Stack of books count - " + stackBooks.Count);

        }
    }
}
