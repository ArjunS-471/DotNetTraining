using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class FileHandling
    {
        public static void MainF()
        {
            string FilePath = @"D:\Samplefile.txt";

            /*FileStream fileStream = new FileStream(FilePath, FileMode.Create);
            FileStream fileStream = new FileStream(FilePath, FileMode.Append);
            byte[] byteData = Encoding.Default.GetBytes("1st file write");
            fileStream.Write(byteData, 0, byteData.Length);
            byte[] byteData2 = Encoding.Default.GetBytes("2nd file write");
            fileStream.Write(byteData2,0, byteData2.Length);
            fileStream.Close();
            */
            string Data;

            FileStream fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                Data= streamReader.ReadToEnd();
            }
            Console.WriteLine(Data);
            fileStream.Close();
        }
    }
}
