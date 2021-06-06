using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _008Task3Professional
{
    [Serializable]
    public class Employee
    {

        public string Name { get; set; }
        public string position { get; set; }
        public Employee() { }
        public Employee(string name, string pos)
        {
            this.Name = name;
            this.position = pos;
        }
    }
    public class EmployeeXml
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string position { get; set; }
        public EmployeeXml() { }
        public EmployeeXml(string name, string pos)
        {
            this.Name = name;
            this.position = pos;
        }
    }
}
