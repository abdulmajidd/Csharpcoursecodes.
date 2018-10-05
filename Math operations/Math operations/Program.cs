using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - / * % 
            int myvar = 15;
            int myvar2 = 10;
            int temp = myvar + myvar2;
            int temp2 = myvar - myvar2;
            int temp3 = myvar % myvar2;
            String mystr = "it is a wonderful";
            String mystr2 = "how is it ?";
            mystr = mystr2 + mystr;
            Console.WriteLine("\nthe resuls is {0} \nthe result 2 is {1} \nthe remaining is {2}", temp, temp2, temp3);
            Console.WriteLine("{0}", mystr);
            Console.ReadKey();
            // + - للفائدة
            int mynegetivevar = -15; 
            // الموجب + هنا ما منه فائدة
            int temp4 = + myvar;
            int temp5 = -myvar;
            int temp6 = +mynegetivevar;
            Console.WriteLine("{0} \n\n{1} \n\n{2}", temp4, temp5,temp6);
            

        }
    }
}
