using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _008Task3Professional
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Employee));
            //Десериализация класса 
            using (FileStream fs = new FileStream("Employee.xml", FileMode.OpenOrCreate))
            {
                Employee newSerailization = (Employee)formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя :{newSerailization.Name}   Должность {newSerailization.position}");
                Console.WriteLine(new string('-', 30));
            }
            //-------------------------------------------------------------------------

            XmlSerializer formater = new XmlSerializer(typeof(EmployeeXml));
            //Десериализация класса атрибутами
            using (FileStream fs = new FileStream("EmployeeBook.xml", FileMode.OpenOrCreate))
            {
                EmployeeXml newSerailization = (EmployeeXml)formater.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя :{newSerailization.Name}   Должность {newSerailization.position}");
                Console.WriteLine(new string('-', 30));
            }
            Console.ReadKey();
        }
    }
}
