using System;

class Program
{
    static void FoldAndSum(int[] arr)
    {
        int k = arr.Length / 4;
        int[] upperRow = new int[2 * k];
        int[] lowerRow = new int[2 * k];

        
        for (int i = 0; i < k; i++)
        {
            upperRow[i] = arr[k - 1 - i];
            upperRow[k + i] = arr[arr.Length - 1 - i];
        }

        
        for (int i = 0; i < 2 * k; i++)
        {
            lowerRow[i] = arr[k + i];
        }

        
        int[] sum = new int[2 * k];
        for (int i = 0; i < 2 * k; i++)
        {
            sum[i] = upperRow[i] + lowerRow[i];
        }

        
        Console.Write("Output : \n1. ");
        Console.WriteLine(string.Join(" ", upperRow));
        Console.Write("2. ");
        Console.WriteLine(string.Join(" ", lowerRow));
        Console.Write("3. ");
        Console.WriteLine(string.Join(" ", sum));
    }

    static void Main(string[] args)
    {
        Console.Write("Input (space-separated array of 4*k integers): ");
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);

        FoldAndSum(arr);
    }
}
