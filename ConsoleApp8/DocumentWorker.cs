using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zavd3
{
     class DocumentWorker
    {
        public virtual  void OpenDocument()
        {
            using (FileStream open = File.OpenRead("D:\\Cheat.txt"))
            {
                byte[] array = new byte[open.Length];
                open.Read(array, 0, array.Length);
                string textofcheats = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine(textofcheats);    
            }
            Console.WriteLine("Документ відкритий");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Правка документа доступна у версії Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа доступне у версії Про");
        }


    }
}
