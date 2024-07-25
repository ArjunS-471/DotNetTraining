namespace Day4
{
    internal class Program
    {
        static void MainParse(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            
            string strNumber = "1";
            //string strNumber = "CSharp";
            //int ParsedNumber =  int.Parse(strNumber);
            bool isInt = int.TryParse(strNumber, out int ParsedNumber);
            if (isInt)
            {
                Console.WriteLine("Your parsed number is - " + ParsedNumber);
            } else
            {
                Console.WriteLine("Parsing failed, provided string not a number");
            }
            Console.WriteLine(ParsedNumber);


        }
    }
}