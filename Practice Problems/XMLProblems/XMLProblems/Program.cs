using System.Xml;

namespace XMLProblems
{
    internal class Program
    {
        static void MainXML1(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            string FileName = "D:\\Input\\Products.xml";
            xmlDoc.Load(FileName);
            xmlDoc.Save(Console.Out);

            Console.WriteLine("\n===============================================");

            //Problem 1

            XmlElement newProd = xmlDoc.CreateElement("Product");

            XmlElement ID = xmlDoc.CreateElement("ID");
            ID.InnerText = "4";
            newProd.AppendChild(ID);

            XmlElement Name = xmlDoc.CreateElement("Name");
            Name.InnerText = "Smartwatch";
            newProd.AppendChild(Name);

            XmlElement Price = xmlDoc.CreateElement("Price");
            Price.InnerText = "250";
            newProd.AppendChild(Price);

            XmlElement Stock = xmlDoc.CreateElement("Stock");
            Stock.InnerText = "15";
            newProd.AppendChild(Stock);

            xmlDoc.DocumentElement.AppendChild(newProd);
            xmlDoc.Save(Console.Out);

            Console.WriteLine("\n===============================================");

            //Problem 2
            foreach(XmlNode prod in xmlDoc.DocumentElement.ChildNodes)
            {
                if (prod["ID"].InnerText == "2" && Convert.ToInt32(prod["Stock"].InnerText) > 30) 
                {
                    prod["Price"].InnerText = "850";
                }
            }
            xmlDoc.Save(Console.Out);
            Console.WriteLine("\n===============================================");

            //Problem 3
            foreach (XmlNode prod in xmlDoc.DocumentElement.ChildNodes)
            {
                if (Convert.ToInt32(prod["Stock"].InnerText) < 10)
                {
                    xmlDoc.DocumentElement.RemoveChild(prod);
                }
            }

            xmlDoc.Save(Console.Out);
            Console.WriteLine("\n===============================================");

            //Product 4

            XmlNodeList xmlProd = xmlDoc.DocumentElement.SelectNodes("Product");

            for (int i = 0; i < xmlProd.Count; i++)
            {
                for (int j = i + 1; j < xmlProd.Count; j++)
                {
                    int id1 = int.Parse(xmlProd[i]["ID"].InnerText);
                    int id2 = int.Parse(xmlProd[j]["ID"].InnerText);

                    if(id1 == id2)
                    {
                        XmlNode tempNode = xmlProd[i].Clone();
                        xmlDoc.DocumentElement.ReplaceChild(tempNode, xmlProd[j]);
                        xmlDoc.DocumentElement.ReplaceChild(xmlProd[j], xmlProd[i]);
                    }
                }
            }
            xmlDoc.Save(Console.Out);

            xmlDoc.Save(FileName);
        }
    }
}