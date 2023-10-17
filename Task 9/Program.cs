using System;

public class LetterIndices
{
    public static void Main(string[] args)
    {
       
        char[] letters = new char[26];
        for (char c = 'a'; c <= 'z'; c++)
        {
            letters[c - 'a'] = c;
        }

       
        Console.Write("Enter a lowercase word: ");
        string word = Console.ReadLine();

      
        Console.WriteLine("Indices of each letter in the letters array:");
        foreach (char letter in word)
        {
            int index = letter - 'a';
            Console.WriteLine($"{letter}: {index}");
        }
    }
}
