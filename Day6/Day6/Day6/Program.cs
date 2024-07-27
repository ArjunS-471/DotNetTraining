namespace Day6
{
    internal class Program
    {   
        class Demo
        {
            public Demo()
            {

            }

            static Demo()
            {
                
            }

            //private Demo()
            //{
                
            //}

            public Demo(int a)
            {
                Console.WriteLine(a);
            }
        }
        static void MainL(string[] args)
        {

            Demo demo = new Demo();
            Console.WriteLine("Hello, World!");

        }
    }
}