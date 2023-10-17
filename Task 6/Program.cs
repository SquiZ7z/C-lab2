using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the elements of the array (space-separated): ");
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);

        int bestStart = 0;
        int bestLen = 1;

        int currentStart = 0;
        int currentLen = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currentLen++;
            }
            else
            {
                currentStart = i;
                currentLen = 1;
            }

            if (currentLen > bestLen)
            {
                bestStart = currentStart;
                bestLen = currentLen;
            }
        }

        Console.WriteLine("Longest sequence of equal elements:");
        for (int i = bestStart; i < bestStart + bestLen; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
