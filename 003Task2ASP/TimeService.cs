using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _003Task2ASP
{

    public class TimeService
    {
        public string GetTime() {
            string result;
            if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour <= 16)
            {
                result= "good afternoon";
            }
            else if (DateTime.Now.Hour >= 16 && DateTime.Now.Hour <= 23)
            {
                result= "good evening";
            }
            else if (DateTime.Now.Hour >= 00 && DateTime.Now.Hour <= 04)
            {
                result= "good night";
            }
            else if (DateTime.Now.Hour >= 04 && DateTime.Now.Hour <= 12)
            {
                result= "good morning";
            }
            else
            {
                result="error!";
            }
            return result.ToString();
        }
    }
}
