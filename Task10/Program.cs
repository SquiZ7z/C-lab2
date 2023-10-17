using System;
using System.Collections.Generic;

public class PairDifferenceCounter
{
    public static int CountPairsWithDifference(int[] numbers, int difference)
    {
        if (numbers == null || numbers.Length < 2)
            throw new ArgumentException("Input array should contain at least two elements.");

        HashSet<int> numberSet = new HashSet<int>(numbers);
        int count = 0;

        foreach (int num in numbers)
        {
            int target1 = num + difference;
            int target2 = num - difference;

            if (numberSet.Contains(target1))
                count++;

            if (numberSet.Contains(target2))
                count++;
        }

        
        return count / 2;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the sequence of numbers (comma-separated): ");
        string[] numbersInput = Console.ReadLine().Split(',');
        int[] numbers = Array.ConvertAll(numbersInput, int.Parse);

        Console.Write("Enter the difference: ");
        int difference = int.Parse(Console.ReadLine());

        int pairCount = CountPairsWithDifference(numbers, difference);
        Console.WriteLine("Number of pairs with the specified difference: " + pairCount);
    }
}
