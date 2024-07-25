namespace Day3
{
    internal class Program
    {
        static void MainREF(string[] args)
        {
            int x = 1, y = 2;
            Console.WriteLine("Initial values - x = " + x + "   y = " + y);
            swap(ref x, ref y);
            Console.WriteLine("After swapping - x = " + x + "   y = " + y);
        }
        
        public static void swap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
            Console.WriteLine("Within function - x = " + x + "   y = " + y);
        }

    }
}