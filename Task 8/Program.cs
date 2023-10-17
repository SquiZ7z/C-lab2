using System;
using System.Collections.Generic;

public class MostFrequentNumber
{
    public static int FindMostFrequentNumber(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Input array cannot be null or empty.");

        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        int mostFrequentNumber = numbers[0];
        int maxFrequency = 1;

        foreach (int num in numbers)
        {
            if (frequencyMap.ContainsKey(num))
                frequencyMap[num]++;
            else
                frequencyMap[num] = 1;

            if (frequencyMap[num] > maxFrequency)
            {
                mostFrequentNumber = num;
                maxFrequency = frequencyMap[num];
            }
        }

        return mostFrequentNumber;
    }

    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 2, 2, 3, 4, 5, 2 };
        Console.WriteLine("Input numbers: [" + string.Join(", ", numbers) + "]");

        int mostFrequent = FindMostFrequentNumber(numbers);
        Console.WriteLine("Most frequent number: " + mostFrequent);
    }
}
