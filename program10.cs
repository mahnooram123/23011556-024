using System;

class NumberInArray
{
    static void Main()
    {
        int[] numbers = new int[5]; 

        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a number to check: ");
        int target = Convert.ToInt32(Console.ReadLine());

        bool exists = Array.Exists(numbers, n => n == target);

        Console.WriteLine(exists
            ? $"{target} exists in the array."
            : $"{target} does not exist in the array.");
    }
}
