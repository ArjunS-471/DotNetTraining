using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace Day13
{
    internal class XSLTDemo
    {
        
        public static void Main6()
        {
            XslTransform xslt = new XslTransform();
            xslt.Load("C:\\Users\\Administrator\\Desktop\\Course-Structure\\Labs\\Day13\\XSLT\\Sample.xslt");
            xslt.Transform("C:\\Users\\Administrator\\Desktop\\Course-Structure\\Labs\\Day13\\xmlfiles\\books.xml", "file.html");

        }
    }
}
