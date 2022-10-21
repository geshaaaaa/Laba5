using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zavd2;

namespace zavd2
{
    internal class ExcelentPupil : Pupil
    {
        

        

        public override void Study()
        {
            Console.WriteLine($"Cтудент вчиться на 5");
        }
        public override void Read()
        {
            Console.WriteLine($"Студент читає 40 сторінок в день ");
        }
        public override void Write()
        {
            Console.WriteLine($"Студент пише лівою рукою");
        }
        public override void Relax()
        {
            Console.WriteLine($"Студент відпочиває 2 години");
        }



    }
}
