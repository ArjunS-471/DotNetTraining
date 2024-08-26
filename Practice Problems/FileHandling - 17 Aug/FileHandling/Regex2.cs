using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml;

namespace FileHandling
{
    internal class Regex2
    {
        public static void MainR2()
        {
            string[] strArrInput;
            string strHtmlText = File.ReadAllText(@"D:\Input\sample.html");
            strArrInput = strHtmlText.Split(new[] {"\n"},StringSplitOptions.None);
            string strWidgetPatternS = @"^<span class=""name"">";
            //string strWidgetPatternS = @"^<span class=""name"">";
            string strPatternEnd = @"</span>";
            string strPricePattern = @"^<span class=""price"">";
            string strName = "";
            string strPrice = "";

            foreach (string str in strArrInput)
            {
                if (Regex.IsMatch(str, strWidgetPatternS))
                {
                    strName = Regex.Replace(str,strWidgetPatternS,"");
                    strName = Regex.Replace(strName, strPatternEnd, "");
                } 
                if (Regex.IsMatch(str,strPricePattern))
                {
                    strPrice = Regex.Replace(str, strPricePattern, "");
                    strPrice = Regex.Replace(strPrice, strPatternEnd, "");
                }
            }
            Console.WriteLine("Product: " + strName.Replace("\r","") + ", Price: " + strPrice.Replace("\r", ""));
        }
    }
}
