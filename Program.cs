using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typecasting
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //Type Casting Program
            int x = (int)3.55;
            float y = (float)6.887;
            double z = 'a';
            long w = 87876549866565636;
            float f = Convert.ToInt32(3.44);
            string r = Convert.ToString("Rohit is a Software Developer");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(w);
            Console.WriteLine(f);
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
