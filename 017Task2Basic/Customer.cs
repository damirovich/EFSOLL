using System;
using System.Collections.Generic;
using System.Text;

namespace _017Task2Basic
{
    class Customer
    {
    
        private string name;
        private string model;
        private string tel;

        public Customer(string name, string model, string tel) 
        {
            this.name = name;
            this.model = model;
            this.tel = tel;
        }

        public string Tel
        {
            get { return tel; }
        }

        public string Model
        {
            get { return model; }
        }

        public string Name
        {
            get { return name; }
        }

        public override string ToString()
        {
            return "Покупатель: " + name + " Модель: " + model + " Телефон: " + tel;
        }
    }
}
