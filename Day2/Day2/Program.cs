namespace Day2
{
    internal class Program
    {
        static void Mainl(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int number = 15;
            //get type
            Type typeOfVariable = number.GetType();
            Console.WriteLine(typeOfVariable);

            //Implicit
            double numDOuble = number;
            Console.WriteLine(numDOuble); // increment

            //Explicit
            int NumberInt = (int)numDOuble; // decrement
            int NumberLong = Convert.ToInt32(numDOuble);
            
            

        }
    }
}