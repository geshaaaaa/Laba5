using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Printer1 printer1 = new Printer1();
            Printer2 printer2 = new Printer2();
            printer.Print<int>("Canon", 3440);
            printer1.Print<string>("HP", "SENSYS_MFU");
            printer2.Print<double>("XEROX", 1.3);
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}
