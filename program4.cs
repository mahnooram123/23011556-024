﻿using System;

class SumCalculator
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;  // Add i to sum
        }

        Console.WriteLine("The sum of numbers from 1 to {n} is {sum}");
    }
}
