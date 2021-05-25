using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002Task3Basic
{
    //enum Position
    //{
    //    Junior,
    //    Middle,
    //    Senior
    //}
    class Employee
    {
        
        private string name;
        private string surname;
        private string position;
        private double salary;
        private int experience;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        public Employee() { }

        public Employee(string name, string surname,double salary,int experience, string position)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            Experience = experience;
            Position = position;
        }

        public void CalculateSalary()
        {
            if (position == "Junior")
                Console.WriteLine("{0}-year Junior's salary:\n" + salary + " * {1} * 0.85 = {2} (Tax 15% = {3})",
                    experience, experience, salary * experience * 0.85, salary * experience / 2 * 0.15);
            else if (position == "Middle")
                Console.WriteLine("{0}-year Middle's salary:\n" + salary + " * {1} * 0.85 = {2} (Tax 15% = {3})",
                    experience, experience, (salary + 10) * experience * 0.90, salary * experience / 2 * 0.15);
            else if (position == "Senior")
                Console.WriteLine("{0}-year Senior's salary:\n" + salary + " * {1} * 0.85 = {2} (Tax 15% = {3})",
                    experience, experience, (salary + 20) * experience * 0.95, salary * experience / 2 * 0.15);
            else {
                Console.WriteLine("Ошибка!");
            }
        }
    }
}

