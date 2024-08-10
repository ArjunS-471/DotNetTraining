using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Reflection.Metadata.BlobBuilder;

namespace Day13
{
    internal class XmlDocumentLoad
    {
        public static void Main3()
        {
            XmlDocument xmlDoc = new XmlDocument();
            string FileName = "C:\\Users\\Administrator\\Desktop\\Course-Structure\\Labs\\Day13\\xmlfiles\\books.xml";
            xmlDoc.Load(FileName);
            xmlDoc.Save(Console.Out);

            Console.WriteLine("\n===============================================");

            XmlDocument xmlDoc1 = new XmlDocument();
            XmlTextReader reader = new XmlTextReader("C:\\Users\\Administrator\\Desktop\\Course-Structure\\Labs\\Day13\\xmlfiles\\books.xml");
            xmlDoc1.Load(reader);
            xmlDoc1.Save(Console.Out);

            XmlTextWriter writer = new XmlTextWriter("C:\\Users\\Administrator\\Desktop\\Course-Structure\\Labs\\Day13\\xmlfiles\\domTest.xml", null);
            writer.Formatting = Formatting.Indented; ;
            //xmlDoc.Save(writer);

            XmlDocumentFragment xoc = xmlDoc.CreateDocumentFragment();
            xoc.InnerXml = "<Record>write some demo sample text</Record>";
            Console.WriteLine(xoc.InnerXml);

            XmlNode root = xmlDoc.DocumentElement;
            root.AppendChild(xoc);
            xmlDoc.Save(writer);

        }
    }
}
