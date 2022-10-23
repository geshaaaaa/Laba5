using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;

namespace zavd3
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            FileInfo edit = new FileInfo(Path);
            Console.WriteLine($"Минуле розширення документа:{edit.Extension}");
            var newextension = System.IO.Path.ChangeExtension(Path, ".docx");
            File.Move(Path, System.IO.Path.ChangeExtension(Path, ".doc"));
            Console.WriteLine($"Документ збережений в новому форматі{edit.Extension}");

        }

    }
}
