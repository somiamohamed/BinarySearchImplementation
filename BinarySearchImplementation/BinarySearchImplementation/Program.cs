using System;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 2, 3, 4, 5, 8 };
        int target = 4;
        int index = BinarySearch(arr, target);

        if (index != -1)
        {
            Console.WriteLine("Element found at index: " + index);
        }
        else
        {
            Console.WriteLine("Element not found.");
        }
    }

    public static int BinarySearch<T>(T[] arr, T target, IComparer<T> comparer = null) where T : IComparable
    {
        if (comparer == null)
        {
            comparer = Comparer<T>.Default;
        }

        int low = 0;
        int hight = arr.Length - 1;

        while (low <= hight)
        {
            int middle = low + (hight - low) / 2;

            if (comparer.Compare(arr[middle], target) == 0)
            {
                return middle;
            }
            else if (comparer.Compare(arr[middle], target) < 0)
            {
                low = middle + 1;
            }
            else
            {
                hight = middle - 1;
            }
        }

        return -1;
    }
}