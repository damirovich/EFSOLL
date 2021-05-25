using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003Task2Basic
{
    class BadPupil:Pupil
    {
        //Плохой учен
        public override string Read()
        {
            return "читает плохо";
        }
        public override string Study()
        {
            return "учится плохо";
        }
        public override string Write()
        {
            return "пишет плохо";
        }
        public override string Relax()
        {
            return "отдыхает плохо";
        }
    }
}
