using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd2
{

    internal class Pupil
    {
        
        

        public virtual void Study()
        {
            Console.WriteLine("Оцінки студента:");
        }
        public virtual void Read()
        {
            Console.WriteLine("Скільки читає студент:");
        }
        public virtual void Write()
        {
            Console.WriteLine("Якою рукою пише студент:");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Скільки відпочиває студент:");
        }

    }
}
