namespace Day9
{
    interface Itest
    {
        void TestMethod();
    }
    class TestClass : Itest
    {
        public void TestMethod() 
        {
            Console.WriteLine("Implicit Interface Implementation");
        }
    }
    class ExplicitTestClass : Itest
    {
        void Itest.TestMethod()
        {
            Console.WriteLine("Explicit Interface Implementation");
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}