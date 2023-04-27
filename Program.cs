using System;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = { -2, -3, 4, 5, 6, 7, 8, 9 };
        int max = arr[0];
        int maxIndex = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                maxIndex = i;
            }
        }
        for (int i = 0; i < maxIndex; i++)
        {
            if (arr[i] < 0)
            {
                arr[i] = 0;
            }
        }
        Console.WriteLine(string.Join(", ", arr));
    }
}