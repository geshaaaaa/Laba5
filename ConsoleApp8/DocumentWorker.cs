using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace zavd3
{
    class DocumentWorker
    {
        public DocumentWorker()
        {
            path = Path;
        }
        string path = "D:\\Cheat.txt";       
        public string Path { get { return path; } }
        public virtual  void OpenDocument()
        {
            
            using (FileStream open = File.OpenRead(path))
            {
                byte[] array = new byte[open.Length];
                open.Read(array, 0, array.Length);
                string textofcheats = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine(textofcheats);
                Console.WriteLine("Документ відкритий");
            }

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
