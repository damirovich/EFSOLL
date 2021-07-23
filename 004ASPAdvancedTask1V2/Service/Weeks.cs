using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _004ASPAdvancedTask1V2.Service
{
    public class Weeks:IWeeks
    {
        public string[] GetWeeks()
        {
          string[] weeks = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.DayNames;
            return weeks;
        }
        //public List<string> GetWeeks()
        //{
        //    return new List<string>()
        //    {
        //        "Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"
        //    };
        //}
    }
}
