using System;
class GradeCalculator
{
    static void Main()
    {
        Console.WriteLine(" Calculator");
        Console.Write("Enter your marks (0-100): ");
        int marks = Convert.ToInt32(Console.ReadLine());
        if (marks < 0 || marks > 100)
        {
            Console.WriteLine("Invalid marks! Please enter a number between 0 and 100.");
        }
        else if (marks >= 90)
        {
            Console.WriteLine("Grade: A+");
        }
        else if (marks >= 80)
        {
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 70)
        {
            Console.WriteLine("Grade: B");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade: C");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("Grade: D");
        }
        else
        {
            Console.WriteLine("Grade: F");
        }
    }
}
