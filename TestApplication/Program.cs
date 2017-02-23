using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args) {
            int i = 0;
           float number = 7.5f;
           if (number > 5 )
            {
                Console.WriteLine("This is greater than 5.");
            }
           else if (number < 5)
            {
                Console.WriteLine("This is less than 5");
            }
           else
            {
                Console.WriteLine("This is equal");
            }

           while (i < 5) {
                Console.WriteLine(i);
                i++;

            }
        }
    }
}
