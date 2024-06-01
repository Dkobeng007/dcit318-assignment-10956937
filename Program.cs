using System;

class Program
{
    static void Main()
    {
        // Define the ticket prices
        const int regularPrice = 10;
        const int discountedPrice = 7;

        // Prompt the user to enter their age
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();
        int age;

        // Check if the input is a valid integer
        if (int.TryParse(input, out age))
        {
            // Determine the ticket price based on the age
            if (age <= 12 || age >= 65)
            {
                Console.WriteLine("Your ticket price is: GHC{0}", discountedPrice);
            }
            else
            {
                Console.WriteLine("Your ticket price is: GHC{0}", regularPrice);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
