using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace _005Task3Professional
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlTextWriter writer = new XmlTextWriter(@"C:\Users\Baktilek\source\repos\005Task3Professional\TelephoneBook.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            createNode("1", "telephone 1", "1000","+996704933737", writer);
            createNode("2", "telephone 2", "2000","+996701526341", writer);
            createNode("3", "telephone 3", "3000","+996500235689", writer);
            createNode("4", "telephone 4", "4000","+996555784512", writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            Console.WriteLine("XML файл был создан ! ");
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"C:\Users\Baktilek\source\repos\005Task3Professional\TelephoneBook.xml");
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }
                // обходим все дочерние узлы элемента user
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    // если узел - company
                    if (childnode.Name == "Number")
                    {
                        Console.WriteLine($"Телефон номера: {childnode.InnerText}");
                    }
                }
            }
                Console.ReadKey();
        }
        public static void createNode(string tID, string tName, string tPrice, string tNumber, XmlTextWriter writer)
        {
            writer.WriteStartElement("Telefon");
            writer.WriteStartElement("Product_id");
            writer.WriteString(tID);
            writer.WriteEndElement();
            writer.WriteStartElement("Name");
            writer.WriteString(tName);
            writer.WriteEndElement();
            writer.WriteStartElement("TelephonePrice");
            writer.WriteString(tPrice);
            writer.WriteEndElement();
            writer.WriteStartElement("Number");
            writer.WriteString(tNumber);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

    }
}
