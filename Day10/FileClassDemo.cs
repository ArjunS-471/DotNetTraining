using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class FileClassDemo
    {
        public static void MainFD()
        {
            string SourceFilePath = @"D:\Samplefile.txt";
            string DestinationFilePath = @"D:\FileDemo\Samplefile.txt";
            string NewFilePath = @"D:\FileDemo\SamplefileNew.txt";
            if (File.Exists(SourceFilePath))
            {
                Console.WriteLine("File exists");
                File.Copy(SourceFilePath, DestinationFilePath,true);
                File.Delete(DestinationFilePath);
                File.Create(NewFilePath);
            }
            else 
            {
                Console.WriteLine("File does not exist");
            }
        }


    }
}
