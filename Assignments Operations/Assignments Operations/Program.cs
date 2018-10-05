using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // =, +=, -=, *=, /=, %=,

            int myvar1 = 7, myvar2 = 3;

             myvar1 = myvar2;       
             myvar1 += myvar2;     // like : myvar1 = myvar1 + myvar2 
             myvar1 -= myvar2;     // like : myvar1 = myvar1 - myvar2 
            myvar1 /= ++myvar2;      // like : myvar1 = myvar1 / ++myvar2  
             myvar1 %= myvar2;          // like : myvar1 = myvar1 % myvar2 
            Console.WriteLine("the resut 1 is {0} the value of var2  is {1}", myvar1, myvar2);
            Console.ReadKey();
        }
    }
}
