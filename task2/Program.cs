using System;

class Program
{
    static void RotateRight(int[] arr, int k)
    {
        int n = arr.Length;
        int[] rotatedArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            int newIndex = (i + k) % n;
            rotatedArr[newIndex] = arr[i];
        }

        for (int i = 0; i < n; i++)
        {
            arr[i] = rotatedArr[i];
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the array of integers (space separated): ");
#pragma warning disable CS8602 
        string[] input = Console.ReadLine().Split(' ');
#pragma warning restore CS8602 
        int[] arr = Array.ConvertAll(input, int.Parse);

        Console.Write("Enter the number of rotations (k): ");
#pragma warning disable CS8604 
        int k = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 

        int n = arr.Length;
        int[] sum = new int[n];

        for (int r = 1; r <= k; r++)
        {
            RotateRight(arr, 1);

            for (int i = 0; i < n; i++)
            {
                sum[i] += arr[i];
            }

            Console.Write($"After rotation {r}: ");
            Console.WriteLine(string.Join(" ", arr));
        }

        Console.WriteLine("Sum array after each rotation:");
        Console.WriteLine(string.Join(" ", sum));
    }
}
