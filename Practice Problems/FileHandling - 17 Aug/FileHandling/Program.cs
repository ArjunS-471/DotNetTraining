namespace FileHandling
{
    internal class Program
    {
        //Log File Analysis
        static void MainLogFileAnalysis(string[] args)
        {
            string strFolderPath = @"D:\Input\";
            string[] strFiles = Directory.GetFiles(strFolderPath, "log_*.txt");

            string strReportPath = @"D:\Input\error_summary.txt";
            string strDBConnFail = "Database Connection Failed";
            List<string> strListErrorTimestamps = new List<string>();

            //For within 1 week criteria
            DateTime datToday = DateTime.Today;
            DateTime datCutOff = datToday.AddDays(-7);

            string strData;
            
            //Looping through each file
            foreach (string file in strFiles)
            {
                string strFileName = Path.GetFileNameWithoutExtension(file);
                string strFileDate = strFileName.Substring(4);

                //Checking file name date format
                if (DateTime.TryParseExact(strFileDate, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime fileDate))
                {
                    //Checking file name criteria of 1 week
                    if (fileDate <= datToday && fileDate >= datCutOff) 
                    {
                        Console.WriteLine("File path - " + file);
                        FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
                        //Reading through each line
                        using StreamReader streamReader = new StreamReader(fileStream);
                        {
                            strData = streamReader.ReadToEnd();
                            //Read data split based on newline and stored in Array
                            string[] arrSplitLines = strData.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                            //Loopin through array
                            foreach (string line in arrSplitLines)
                            {
                                if (line.Contains(strDBConnFail))
                                {
                                    Console.WriteLine(line);
                                    //Extracting timestamp
                                    int intStartIndex = line.IndexOf("[") + 1;
                                    int intEndIndex = line.IndexOf("]");
                                    string strExtractTimeStamp = line.Substring(intStartIndex, intEndIndex - intStartIndex);
                                    //Adding extracted timestamp to a list
                                    strListErrorTimestamps.Add(strExtractTimeStamp);
                                }
                            }
                        }
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Writing to report file - ");
            StreamWriter streamWriter = new StreamWriter(strReportPath, false);
            string strOutputData = "Error Summary Report" + "\n" + $"- Error Type: {strDBConnFail}" + "\n" + $"- Occurences: {strListErrorTimestamps.Count}" + "\n" + "- Timestamps:" + "\n";
            foreach(string str in strListErrorTimestamps)
            {
                strOutputData = strOutputData + "\t- " + str + "\n";
            }
            Console.WriteLine("Output - " + strOutputData);
            streamWriter.Write(strOutputData);
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}