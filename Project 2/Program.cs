using System;
using System.Linq;

class Program
{
    static int FindLargestCommonEndLength(string[] arr1, string[] arr2, bool fromLeft)
    {
        int maxLength = 0;
        int length1 = arr1.Length;
        int length2 = arr2.Length;

        int minLength = Math.Min(length1, length2);

        if (fromLeft)
        {
            for (int i = 0; i < minLength; i++)
            {
                if (arr1[i] == arr2[i])
                    maxLength++;
                else
                    break;
            }
        }
        else
        {
            for (int i = 0; i < minLength; i++)
            {
                if (arr1[length1 - 1 - i] == arr2[length2 - 1 - i])
                    maxLength++;
                else
                    break;
            }
        }

        return maxLength;
    }

    static string GetCommonEnd(string[] arr, int length, bool fromLeft)
    {
        if (fromLeft)
            return string.Join(" ", arr.Take(length));
        else
            return string.Join(" ", arr.Reverse().Take(length).Reverse());
    }

    static void Main(string[] args)
    {
        string[] array1 = { "hi", "php", "java", "csharp", "sql", "html", "css", "js" };
        string[] array2 = { "nakov", "java", "sql", "html", "css", "js" };

        int leftCommonEndLength = FindLargestCommonEndLength(array1, array2, true);
        int rightCommonEndLength = FindLargestCommonEndLength(array1, array2, false);

        if (leftCommonEndLength == 0 && rightCommonEndLength == 0)
            Console.WriteLine("No common words at the left and right");
        else if (leftCommonEndLength >= rightCommonEndLength)
            Console.WriteLine("The largest common end is at the left: " + GetCommonEnd(array1, leftCommonEndLength, true));
        else
            Console.WriteLine("The largest common end is at the right: " + GetCommonEnd(array1, rightCommonEndLength, false));
    }
}
