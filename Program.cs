using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine($"{input} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{input} is not a palindrome.");
        }
    }

    static bool IsPalindrome(string input)
    {
        input = input.ToLower(); // Convert to lowercase for case-insensitivity
        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            if (input[left] != input[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
