using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class overloading
    {
        void Sum(int a ,int b)
        {
          Console.WriteLine(a+b);
        }
        void Sum(float a ,float b)
        {
          Console.WriteLine(a+b);
        }
        void Sum(float a, float b,float c)
        {
            Console.WriteLine(a + b+c);
        }
        public static void Main(string[] args)
            {
                overloading obj = new overloading();
                obj.Sum(10, 20,30);
                Console.ReadKey();
            }
        }
    }

    


    
