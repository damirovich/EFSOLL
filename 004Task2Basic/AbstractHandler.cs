using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004Task2Basic
{
    abstract class AbstractHandler
    {

        public abstract void open();
        public abstract void create();
        public abstract void change();
        public abstract void save();
    }
}
