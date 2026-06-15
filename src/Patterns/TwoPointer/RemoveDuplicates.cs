namespace TwoPointer;

internal class RemoveDuplicates
{
    public static void Remove()
    {
        int[] arrr = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
        int low = 0;
        int high = 1;
        int cntr = 1;

        while (high < arrr.Length)
        {
            if (arrr[high] != arrr[low])
            {
                arrr[low + 1] = arrr[high];
                high++;
                low++;
                cntr++;
            }
            else
            {
                high++;
            }
        }
        Console.WriteLine(cntr);

        Console.WriteLine(String.Join(',',arrr));
    }
}
