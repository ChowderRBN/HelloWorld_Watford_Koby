using System;

class Program
{
    static void Main()
    {
        // Display a welcome message
        Console.WriteLine("Welcome to the program!");

        // Ask the user for their first name
        Console.Write("Please enter your first name: ");
        string firstName = Console.ReadLine(); // Store the input in firstName variable

        // Ask the user for their last name
        Console.Write("Please enter your last name: ");
        string lastName = Console.ReadLine(); // Store the input in lastName variable

        // Print a personalized greeting
        Console.WriteLine($"Hello, {firstName} {lastName}!");
    }
}
