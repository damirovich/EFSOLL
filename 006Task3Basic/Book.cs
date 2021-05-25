using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006Task3Basic
{
    class Book
    {
        public class Notes {
            string text = "";
            public string Text 
            {
                get 
                {
                    return text;
                }
                set 
                {
                    if (text != "")
                        text += "\n";
                    text += value;
                }

            }
        }
    }
}
