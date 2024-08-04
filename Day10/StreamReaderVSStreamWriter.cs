using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day10
{
    internal class StreamReaderVSStreamWriter
    {
        public static void MainFS()
        {
            string FilePath = @"D:\Samplefile.txt";
            //StreamWriter streamWriter = new StreamWriter(FilePath);
            //Console.WriteLine("Please enter some string to write to file");
            //string inputData = Console.ReadLine();
            //streamWriter.Write(inputData);
            //streamWriter.Flush();
            //streamWriter.Close();

            //Console.WriteLine("Please enter number 1 ");
            //int inputData1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter number 2 ");
            //int inputData2 = Convert.ToInt32(Console.ReadLine());
            //streamWriter.Write(inputData1 + inputData2);
            //streamWriter.Flush();
            //streamWriter.Close();

            //Console.WriteLine("Please enter some text");
            //string inputData3 = Console.ReadLine();
            //using (StreamWriter writer = new StreamWriter(FilePath, true))
            //{
            //    writer.WriteLine(inputData3);
            //}
            //string fileContent = File.ReadAllText(FilePath);
            //Console.WriteLine(fileContent);

            StreamReader stream = new StreamReader(FilePath);
            Console.WriteLine("Content from file");
            //stream.BaseStream.Position = 0;
            stream.BaseStream.Seek(0, SeekOrigin.Begin);
            string strData = stream.ReadLine();
            while (strData != null)
            {
                Console.WriteLine(strData);
                strData = stream.ReadLine();
            }
        }
    }
}
