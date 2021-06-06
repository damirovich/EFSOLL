using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _008Task2Professional
{
    [Serializable]
    public class Serailizationn
    {
        public string Name { get; set; }
        public string position { get; set; }
        public Serailizationn() { }
        public Serailizationn(string name, string pos) {
            this.Name = name;
            this.position = pos;
        }
    }
    public class SerializationXML { 
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string position { get; set; }
        public SerializationXML() { }
        public SerializationXML(string name, string pos) {
            this.Name = name;
            this.position = pos;
        }
    }
}
