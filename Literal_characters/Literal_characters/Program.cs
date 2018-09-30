using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int Myvar = -100;
            uint myuvar = 1000u;
            float myFLvar = 1.5F;
            double myDvar = 3.5;
            decimal mydecvar = 100.5M;
            Console.WriteLine("{0} {1} ", Myvar, myuvar);
            Console.Write($"(Myvar),(myuvar)");
            Console.ReadKey();
        }
    }
}
