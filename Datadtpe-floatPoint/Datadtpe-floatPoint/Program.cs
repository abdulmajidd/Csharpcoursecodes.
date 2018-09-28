using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datadtpe_floatPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            float flmin =  float.MinValue;
            float flmax = float.MaxValue;
            Console.WriteLine("Min Value = {0} Max Value = {1}", flmin, flmax);

            float flVar = 1F / 3;
            Double dlVAr = 1D / 3;
            decimal dcVar = 1M / 3;
            Console.WriteLine("/nfloat Value ={0}/nDouble Value ={1}/ndecimal Value ={2}", flVar, dlVAr, dcVar);
            Console.ReadKey();




        }
    }
}
