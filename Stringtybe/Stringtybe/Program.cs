using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringtybe
{
    class Program
    {
        static void Main(string[] args)
        {
            // \',\",\\,\0,\a,\b,\n,\r,\t,\v,\f,@
            String mystring = "nazar said this is a good cours,and I think";
            String mystring2 = @"yes it is";
            String mystring3 = mystring + mystring2;
            Console.WriteLine("{0}", mystring3);
            Console.ReadKey(); 
            
        }
    }
}
