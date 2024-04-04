// Utilize System namespace to access Random class
using System;

// Define a class to encapsulate random number generation functionality
public static class RandomNumberGenerator
{
    // Create a single instance of Random to prevent repetition of random numbers
    // due to similar seed values when instantiated multiple times in quick succession
    private static readonly Random random = new Random();

    // Lock object for thread-safety when generating random numbers
    private static readonly object syncLock = new object();

    // Method to generate a random integer within a specified range
    public static int Next(int minValue, int maxValue)
    {
        // Synchronize access to the random instance across threads
        lock (syncLock)
        {
            // Return a random integer within the specified range
            return random.Next(minValue, maxValue);
        }
    }

    // Method to generate a random double number
    public static double NextDouble()
    {
        // Synchronize access to the random instance across threads
        lock (syncLock)
        {
            // Return a random double number between 0.0 and 1.0
            return random.NextDouble();
        }
    }

    // Add more methods as needed to extend functionality
}
