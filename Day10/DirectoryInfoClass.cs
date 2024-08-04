using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class DirectoryInfoClass
    {
        public static void Main()
        {
            string NewFilePath = @"D:\FileDemo\Sample";
            string NewFilePath1 = @"D:\FileDemo2";
            DirectoryInfo f1 = new DirectoryInfo(NewFilePath);
            //f1.Create();

            //f1.CreateSubdirectory("TestSample");
            DirectoryInfo d1 = new DirectoryInfo(NewFilePath);
            DirectoryInfo d2 = new DirectoryInfo(NewFilePath1);
            //d1.MoveTo(NewFilePath1);
            //d2.Delete();
            Directory.Delete(NewFilePath1, true);

        }
    }
}
