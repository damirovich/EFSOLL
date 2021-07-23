using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _004ASPAdvancedTask1V2.Service
{
    public class Months:IMonth
    {
        public string[] GetMonths()
        {
            string[] month = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            return month;
        }
        //public List<string> GetMonths()
        //{
        //    return new List<string>()
        //    {
        //        "Январь", "Февраль", "Март", "Апрель", "Май","Июнь","Июль",
        //        "Август","Сенятбрь","Октябрь","Ноябрь","Декабрь"
        //    };
        //}
    }
}
