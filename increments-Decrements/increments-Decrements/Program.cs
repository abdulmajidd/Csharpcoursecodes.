using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increments_Decrements
{
    class Program
    {
        static void Main(string[] args)
        {//   اذا جات الاشارات قبل المتغير معناها نزود او ننقص واحد على حسب الي يجيني واذا جات بعدها تبقى قيمة المتغير نفسها 
            int myvar = 2;
            int temp = myvar--;
            Console.WriteLine("{0}", temp );
            Console.ReadKey();
        }
    }
}
