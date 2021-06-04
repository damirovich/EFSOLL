using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Task2Ppofessional
{
    class Calendar : IEnumerable, IEnumerator
    {
        int[] month = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        int[] day = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        string[] nameMonth = { "Январ", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        int position = -1;

        public object Current
        {
            get { return "Номер "+ month[position] + " - " +" месяц "+nameMonth[position]+" - " + " Колличество день " + day[position]; }
        }

        public bool MoveNext()
        {
            if (position < month.Length - 1)
            {
                position++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public string GetMonthByDays(int days)
        {
            string months = string.Empty;

            for (int i = 0; i < day.Length; i++)
            {
                if (day[i] == days)
                {
                    months += "Номер " + month[i] + " - " + " Месяц " + nameMonth[i] + " - " + " Колличество дней " + day[i] + "\n";
                }
            }

            return months;
        }

        public string GetDaysByMonth(int months)
        {
            string mounths = string.Empty;

            for (int i = 0; i < month.Length; i++)
            {
                if (month[i] == months)
                {
                    mounths += "Номер " + month[i] + " - "+" Месяц " +nameMonth[i]+ " - " +" Колличество дней "+ day[i] + "\n";
                }
            }

            return mounths;
        }
    }
}
