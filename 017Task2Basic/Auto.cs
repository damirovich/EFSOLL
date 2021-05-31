using System;
using System.Collections.Generic;
using System.Text;

namespace _017Task2Basic
{
    class Auto
    {
        private string marka;
        private string model;
        private int year;
        private string color;

        public Auto(string marka, string model, int year, string color) 
        {
            this.marka = marka;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public string Color
        {
            get { return color; }
        }

        public string Model
        {
            get { return model; }
        }

        public int Year
        {
            get { return year; }
        }

        public string Marka
        {
            get { return marka; }
        }

        public override string ToString() 
        {
            return "Марка: " + marka + " Модель: " + model + " Год выпуска: " + year + " Цвет: " + color;
        }
    }
}
