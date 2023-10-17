using System;
using System.Collections.Generic;

public class LongestIncreasingSubsequence
{
    public static List<int> FindLongestIncreasingSubsequence(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            return new List<int>();

        int n = arr.Length;
        int[] lisLength = new int[n];
        int[] prevIndices = new int[n];
        for (int i = 0; i < n; i++)
        {
            lisLength[i] = 1;
            prevIndices[i] = -1;
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (arr[i] > arr[j] && lisLength[i] < lisLength[j] + 1)
                {
                    lisLength[i] = lisLength[j] + 1;
                    prevIndices[i] = j;
                }
            }
        }

        int maxLength = lisLength[0];
        int maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (lisLength[i] > maxLength)
            {
                maxLength = lisLength[i];
                maxIndex = i;
            }
        }

        List<int> longestSubsequence = new List<int>();
        while (maxIndex != -1)
        {
            longestSubsequence.Insert(0, arr[maxIndex]);
            maxIndex = prevIndices[maxIndex];
        }

        return longestSubsequence;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 3, 10, 2, 1, 20 };
        Console.WriteLine("Input array: [" + string.Join(", ", arr) + "]");
        List<int> lis = FindLongestIncreasingSubsequence(arr);
        Console.WriteLine("Longest increasing subsequence: [" + string.Join(", ", lis) + "]");
    }
}
