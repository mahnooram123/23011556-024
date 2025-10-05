using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace mahnoorsonsoleapp
{
     class program
    {
        static void Main() //git changes are done
        {
            Console.WriteLine("let's check if the number is even or odd");
            Console.WriteLine("enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number %2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
