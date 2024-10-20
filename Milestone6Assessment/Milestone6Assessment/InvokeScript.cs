using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Milestone6Assessment
{
    internal class InvokeScript
    {
        public static void Main()
        {
            //Process instance creation
            var psi2 = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = "sum_script.py 1 2",
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };
            //Execution
            var process1 = Process.Start(psi2);
            //Output and Error if any
            string output1 = process1.StandardOutput.ReadToEnd();
            string errors1 = process1.StandardError.ReadToEnd();
            process1.WaitForExit();
            Console.WriteLine("Output :" + output1);
            Console.WriteLine("Errors :" + errors1);

        }
    }
}
