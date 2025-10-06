using System;
namespace mahnoorconsoleapp
{
    class Factorialprogram
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            int i = 1;

            while (i <= n)
            {
                factorial *= i;  
                i++;
            }

            Console.WriteLine("Factorial of {n} is {factorial}");
        }
    }
}
