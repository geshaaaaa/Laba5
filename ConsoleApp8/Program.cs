using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using zavd3;
using System.IO;

namespace zavd3

{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           


            Console.WriteLine("Do you have key of program? Yes/No");
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "No":
                    {
                        DocumentWorker documentWorke = new DocumentWorker();
                        documentWorke.OpenDocument();
                        documentWorke.EditDocument();
                        documentWorke.SaveDocument();
                        break;
                    }
                case "Yes":
                    {
                        Console.WriteLine("Etner the key");
                        string keyw = Console.ReadLine();
                        int key = int.Parse(keyw);
                        if (key == 1)
                        {
                            ProDocumentWorker proDocumentWorker = new ProDocumentWorker();
                            proDocumentWorker.OpenDocument();
                            proDocumentWorker.EditDocument();
                            proDocumentWorker.SaveDocument();
                        }
                        if (key == 2)
                        {
                            ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                            expertDocumentWorker.OpenDocument();
                            expertDocumentWorker.EditDocument();
                            expertDocumentWorker.SaveDocument();

                        }
                        
                        break;
                    }
            }
            }
    }
}
