using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the lengths of the three sides of the triangle
        Console.Write("Enter the length of side 1: ");
        string input1 = Console.ReadLine();
        Console.Write("Enter the length of side 2: ");
        string input2 = Console.ReadLine();
        Console.Write("Enter the length of side 3: ");
        string input3 = Console.ReadLine();

        // Attempt to parse the inputs to double values
        double side1, side2, side3;

        if (double.TryParse(input1, out side1) && double.TryParse(input2, out side2) && double.TryParse(input3, out side3))
        {
            // Determine the type of the triangle based on the lengths of its sides
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numerical values for the sides of the triangle.");
        }
    }
}
