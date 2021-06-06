using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _008Task2Professional
{
    class Program
    {
        static void Main(string[] args)
        {
            Serailizationn serailizationn = new Serailizationn("Baktilek","Senior");
          
            XmlSerializer formatter = new XmlSerializer(typeof(Serailizationn));
            //Сериализация
            using (FileStream fs = new FileStream("Employee.xml", FileMode.OpenOrCreate)) {
                formatter.Serialize(fs, serailizationn);
                Console.WriteLine("Объект сериализован");
            }
           
            //-------------------------------------------------------------------------
            //Сериализация класа в xml через атрибуты
            SerializationXML serializationXML = new SerializationXML("Samat", "Director");
        
            XmlSerializer formater = new XmlSerializer(typeof(SerializationXML));
            //Сериализация
            using (FileStream fs = new FileStream("EmployeeBook.xml", FileMode.OpenOrCreate))
            {
                formater.Serialize(fs, serializationXML);
                Console.WriteLine("Объект сериализован");
            }
            Console.ReadKey();
        }
    }
}
