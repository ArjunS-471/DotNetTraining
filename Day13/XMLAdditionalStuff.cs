using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day13
{
    internal class XMLAdditionalStuff
    {
        public static void Main5()
        {
            XmlDocument xmlDoc = new XmlDocument();
            string FileName = "C:\\Users\\Administrator\\Desktop\\Course-Structure\\Labs\\Day13\\xmlfiles\\books.xml";
            xmlDoc.Load(FileName);
            xmlDoc.Save(Console.Out);

            Console.WriteLine("\n**********************************************");

            XmlNode root = xmlDoc.DocumentElement;

            //root.RemoveAll();

            //root.RemoveChild(root.FirstChild);

            XmlElement ele = xmlDoc.CreateElement("title");
            ele.InnerText = "LOTR";
            ele = xmlDoc.CreateElement("Author");
            ele.InnerText = "Tolkien";
            

            root.ReplaceChild(ele, root.LastChild);

            xmlDoc.Save(Console.Out);

        }
    }
}
