using System;

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
            int digit = num % 10;      // Get the last digit
            reversed = reversed * 10 + digit; // Append it to reversed number
            num /= 10;                 // Remove the last digit
        }

        Console.WriteLine($"The reverse of {original} is {reversed}");
    }
}
