using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poolean_Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            // Boolean comparison ==, !=, <, >, <=, >=                                         
            // Boolean Conditions &&, ||                                                // && Table Truth 
                                                                                        // F  F --> F 
                                                                                        // F  T --> F
                                                                                        // T  T --> T
                                                                                        // T  F --> F                  
            bool myresult;                                                                          
            int myvar1 = 5, myvar2 = 8 ;
            myresult = myvar1 != 8;
            myresult = (myvar1 <= 5) && (myvar2 > 10);                                       
            Console.WriteLine("myresult is = {0}", myresult );
            Console.ReadKey();
           
        }
    }
}
