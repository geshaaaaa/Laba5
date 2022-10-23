using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zavd3
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Внесіть зміни в документ:");
            string editText = Console.ReadLine();
            
            using (FileStream edit = new FileStream(Path, FileMode.Open))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(editText);
                edit.Write(array, 0, array.Length);
                Console.WriteLine("Файл відредаговано");


            }

            
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт");
        }

    }
}
