using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zavd2;

namespace zavd2
{
    internal class GoodPupil : Pupil
    {
        
        public override void Study()
        {
            Console.WriteLine($"Cтудент вчиться на 4");
        }
        public override void Read()
        {
            Console.WriteLine("Студент читає 15 сторінок в день ");
        }
        public override void Write()
        {
            Console.WriteLine("Студент пише правою рукою");
        }
        public override void Relax()
        {
            Console.WriteLine("Студент відпочиває 4 години");
        }
    }
}
