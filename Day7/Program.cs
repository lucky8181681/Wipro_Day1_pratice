using System;

class Program
{
    static int LinearSearch(int[] arr, int key)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
                return i;
        }
        return -1;
    }
    static int BinarySearch(int[] arr, int key)
    {
        int low = 0, high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == key)
                return mid;
            else if (arr[mid] < key)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return -1;
    }
    static void Main()
    {
        int[] arr = { 23, 2, 89, 45, 25, 9, 78, 12 };
        int key = 45;
        int linearResult = LinearSearch(arr, key);
        Console.WriteLine("Linear Search:");
        Console.WriteLine(linearResult != -1
            ? $"Element found at index: {linearResult}"
            : "Element not found");
        int[] sortedArr = (int[])arr.Clone();
        Array.Sort(sortedArr);
        int binaryResult = BinarySearch(sortedArr, key);
        Console.WriteLine("\nBinary Search:");
        Console.WriteLine(binaryResult != -1
            ? $"Element found at index: {binaryResult}"
            : "Element not found"); 

    }
}