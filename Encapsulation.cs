using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohitconsoleapp
{
    internal class Encapsulation
    {
        public class Example
        {
            public int x;
        }
        class Sample
        {
            public static void Main()
            {
                Example e = new Example();
                e.x = 50;
                Console.WriteLine(e.x);
                e.x = -10;
                Console.WriteLine(e.x);
                Console.WriteLine("Press any key to exist");
                Console.ReadKey();
            }
        }

    }
}
