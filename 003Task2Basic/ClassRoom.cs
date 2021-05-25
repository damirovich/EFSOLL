using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003Task2Basic
{
    class ClassRoom
    {
        Pupil pupil_1;
        Pupil pupil_2;
        Pupil pupil_3;
        Pupil pupil_4;
        Pupil[] pupils = new Pupil[4];

        public ClassRoom(Pupil pupil_1, Pupil pupil_2, Pupil pupil_3, Pupil pupil_4)
        {
            this.pupil_1 = pupil_1;
            this.pupil_2 = pupil_2;
            this.pupil_3 = pupil_3;
            this.pupil_4 = pupil_4;


            Console.WriteLine($"1 ученик {pupil_1.Read()}, {pupil_1.Study()}, {pupil_1.Write()}, {pupil_1.Relax()}");
            Console.WriteLine($"2 ученик {pupil_2.Read()}, {pupil_2.Study()}, {pupil_2.Write()}, {pupil_2.Relax()}");
            Console.WriteLine($"3 ученик {pupil_3.Read()}, {pupil_3.Study()}, {pupil_3.Write()}, {pupil_3.Relax()}");
            Console.WriteLine($"4 ученик {pupil_4.Read()}, {pupil_4.Study()}, {pupil_4.Write()}, {pupil_4.Relax()}");

            pupils[0] = this.pupil_1;
            pupils[1] = this.pupil_2;
            pupils[2] = this.pupil_3;
            pupils[3] = this.pupil_4;

            GetInfo();

        }
        public ClassRoom(Pupil pupil_1, Pupil pupil_2)
        {
            this.pupil_1 = pupil_1;
            this.pupil_2 = pupil_2;

            Console.WriteLine($"1 ученик {pupil_1.Read()}, {pupil_1.Study()}, {pupil_1.Write()}, {pupil_1.Relax()}");
            Console.WriteLine($"2 ученик {pupil_2.Read()}, {pupil_2.Study()}, {pupil_2.Write()}, {pupil_2.Relax()}");
            Console.WriteLine($"Про 3 и 4 учеников ничего не известно");

            pupils[0] = pupil_1;
            pupils[1] = pupil_2;

            GetInfo();

        }
        public void GetInfo()
        {
            byte numOfExlecent = 0, numOfGood = 0, numOfBad = 0;

            foreach (Pupil i in pupils)
            {
                if (i is ExcelentPupil) numOfExlecent++;
                else if (i is GoodPupil) numOfGood++;
                else if (i is BadPupil) numOfBad++;
            }
            Console.WriteLine($"В классе {numOfExlecent} отличных, {numOfGood} хороших и {numOfBad} плохих учеников");
        }
    }
}
