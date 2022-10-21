using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Printer 
    {

      
        
        public virtual void  Print<T>(string value, T a)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Company:{value} Model:{a} ");
           
        }
        

    }



     





}