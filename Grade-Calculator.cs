using System;

// Prompt the user to enter a numerical grade
Console.Write("Enter a numerical grade between 0 and 100: ");
string input = Console.ReadLine();
int grade;

// Check if the input is a valid integer
if (int.TryParse(input, out grade))
{
    // Check if the grade is within the valid range
    if (grade < 0 || grade > 100)
    {
        Console.WriteLine("Invalid grade. Please enter a grade between 0 and 100.");
    }
    else
    {
        // Determine the letter grade based on the numerical grade
        if (grade >= 90)
        {
            Console.WriteLine("Your grade is: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your grade is: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your grade is: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is: D");
        }
        else
        {
            Console.WriteLine("Your grade is: F");
        }
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a numerical grade.");
}
