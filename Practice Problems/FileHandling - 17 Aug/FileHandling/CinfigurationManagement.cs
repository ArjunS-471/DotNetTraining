using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Xml.Linq;

namespace FileHandling
{
    internal class CinfigurationManagement
    {
        public static void MainJSONXML()
        {
            string strJSONPath = @"D:\Input\appsettings.json";
            string strXMLPath = @"D:\Input\Config.xml";

            //Updating JSON item
            string strJSON = File.ReadAllText(strJSONPath);
            JsonObject jsonObject = JsonNode.Parse(strJSON).AsObject();
            JsonObject jsonObjectDB = jsonObject["Database"].AsObject();
            jsonObjectDB["ConnectionString"] = "Server=prodserver;Database=mydb;";
            strJSON = JsonSerializer.Serialize(jsonObject, new JsonSerializerOptions { WriteIndented = true});
            File.WriteAllText(strJSONPath, strJSON);

            //Updating XML item
            XDocument xmlDoc = XDocument.Load(strXMLPath);
            XElement firstNode = xmlDoc.Root.Element("database");
            XElement secondNode = firstNode.Element("connectionString");
            secondNode.Value = "Server=prodserver;Database=mydb;";
            xmlDoc.Save(strXMLPath);
        }
    }
}
