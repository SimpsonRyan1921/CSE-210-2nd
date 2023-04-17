using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);
        string letterGrade = "NULL";

        if (grade >= 90)
        {
            letterGrade = "A";
        }

        else if (grade >= 80)
        {
            letterGrade = "B";
        }

        else if (grade >= 70)
        {
            letterGrade = "C";
        }

        else if ( grade >= 60)
        {
            letterGrade = "D";
        }

        else
        {
            letterGrade = "F";
        }

        Console.Write($"Your grade is a {letterGrade}");
    }
}