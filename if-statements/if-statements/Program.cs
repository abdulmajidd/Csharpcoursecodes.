using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int myvar = 10;
            if (myvar == 11)
             
                Console.WriteLine("the Variable equel 10");
            else
                Console.WriteLine("the Variable is not equel 10");
            Console.ReadKey();
            */
            /*
            int myvar1 = 9, myvar2 = 7;
            if ((myvar1 <= 9) || (myvar2 >= 7)) 
            {
                Console.WriteLine("the condations is true");

            }
            else
            {
                Console.WriteLine("the condations is False");

            }
            Console.ReadKey();
            */
            int myvar = 9;
            String myresult;

            if (myvar < 10)
            {
                myresult = "less than 10";
                Console.WriteLine(myresult);
            }
            if(myvar>10)
            {
                myresult = "Greater than 10";
                Console.WriteLine(myresult);
            }
            if(myvar==10)
            {
                myresult = "equel 10";
                Console.WriteLine(myresult);
            }
            Console.ReadKey();




        }
    }
}
