using System;

class EvenOddCounter
{
    static void Main()
    {
        int[] numbers = new int[10];
        int evenCount = 0, oddCount = 0;
        Console.WriteLine("Enter 10 integers:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            if (numbers[i] % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        Console.WriteLine($"\nNumber of even numbers: {evenCount}");
        Console.WriteLine($"Number of odd numbers: {oddCount}");
    }
}
