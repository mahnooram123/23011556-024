using System;
namespace mahnoorconsoleapp
{
    class ReverseNumber
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int reversed = 0;
            int original = num;
            while (num != 0)
            {
                int digit = num % 10;      
                reversed = reversed * 10 + digit; 
                num /= 10;               
            }

            Console.WriteLine("The reverse of {original} is {reversed}");
        }
    }
}
