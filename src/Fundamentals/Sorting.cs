namespace Fundamentals;

internal static class Sorting
{
    internal static void SelectionSort(int[] arr)
    {
        Console.WriteLine($"Before Sorting: {String.Join(",", arr)}");
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min =i;
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }
            //swap
            (arr[i], arr[min]) = (arr[min], arr[i]);
        }
        Console.WriteLine($"After Sorting: {String.Join(",", arr)}");
    }
    internal static void InsertionSort(int[] arr)
    {
        Console.WriteLine("Insertion Sort:");
        Console.WriteLine($"Before Sort: {String.Join(",", arr)}");

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int j = i+1;

            while (j > 0 && arr[j - 1] > arr[j])
            {
                (arr[j - 1], arr[j]) = (arr[j], arr[j - 1]);
                j--;
            }
        }
        Console.WriteLine($"After Sort: {String.Join(",", arr)}");
    }
    internal static void BubbleSort(int[] arr)
    {
        Console.WriteLine("Bubble Sort:");
        Console.WriteLine($"Before Sort: {String.Join(",", arr)}");
        bool isSwapped=false;
        //for Passes
        for (int i = 0; i < arr.Length - 1; i++)
        {
            //Number of comaprison
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    isSwapped = true;
                }
            }

            if (!isSwapped)
                break;
        }

        Console.WriteLine($"After Sort: {String.Join(",", arr)}");

    }

}
