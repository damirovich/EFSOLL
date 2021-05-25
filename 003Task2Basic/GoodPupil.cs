using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003Task2Basic
{
    class GoodPupil:Pupil
    {
        public override string Read()
        {
            return "читает хорошо";
        }
        public override string Study()
        {
            return "учится хорошо";
        }
        public override string Write()
        {
            return "пишет хорошо";
        }
        public override string Relax()
        {
            return "отдыхает хорошо";
        }
    }
}
