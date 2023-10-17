using System;

class Program
{
    static void CompareAndPrint(char[] arr1, char[] arr2)
    {
        int minLength = Math.Min(arr1.Length, arr2.Length);
        int i = 0;

        while (i < minLength)
        {
            if (arr1[i] < arr2[i])
            {
                PrintCharArray(arr1);
                PrintCharArray(arr2);
                return;
            }
            else if (arr1[i] > arr2[i])
            {
                PrintCharArray(arr2);
                PrintCharArray(arr1);
                return;
            }

            i++;
        }

        
        if (arr1.Length < arr2.Length)
        {
            PrintCharArray(arr1);
            PrintCharArray(arr2);
        }
        else if (arr1.Length > arr2.Length)
        {
            PrintCharArray(arr2);
            PrintCharArray(arr1);
        }
        else
        {
            
            PrintCharArray(arr1);
            PrintCharArray(arr2);
        }
    }

    static void PrintCharArray(char[] arr)
    {
        foreach (char c in arr)
        {
            Console.WriteLine(c);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the first char array: ");
        string input1 = Console.ReadLine();
        char[] arr1 = input1.ToCharArray();

        Console.Write("Enter the second char array: ");
        string input2 = Console.ReadLine();
        char[] arr2 = input2.ToCharArray();

        Console.WriteLine("Arrays in alphabetical order:");

        CompareAndPrint(arr1, arr2);
    }
}
