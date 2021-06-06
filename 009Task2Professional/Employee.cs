using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009Task2Professional
{
    class Employee
    {
        public string Name { get; set; }
        public string position { get; set; }
        public int Age { get; set; }
        public Employee() { }
        public Employee(string name, string pos, int age) {
            this.Name = name;
            this.position = pos;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"Имя: {Name}, должность: {position}, возраст: {Age}.";
        }
        bool IsMemoryLimitExceeded()
        {
            return this.Age < GC.GetTotalMemory(false);
        }

        public void WarnIfMemoryLimitExceeded(object errorMessage)
        {
            if (IsMemoryLimitExceeded())
            {
                Console.WriteLine("{0}", errorMessage);
            }
        }
    }
}
