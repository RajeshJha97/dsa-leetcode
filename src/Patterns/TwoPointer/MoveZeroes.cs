namespace TwoPointer;

internal static class MoveZeroes
{
    public static void MoveZeroesToLeft()
    {
         int[] arr = [0, 1, 0, 1, 0, 1, 1, 1, 0];

        //pointer one will be set for the first non-zeroes
        int p1 = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                p1 = i ;
                break;
            }
           
        }

        int p2 = p1 + 1;

        while (p2 < arr.Length)
        {
            if (arr[p2] == 0)
            {
                (arr[p1], arr[p2]) = (arr[p2], arr[p1]);
                p1++;
                p2++;
            }
            else {

                p2++;
            }
        }

        Console.Write("Move Zeroes to Left: ");
        Console.WriteLine(String.Join(',', arr));
    }

    public static void MoveZeroesToRight()
    {
        int[] arr = [0, 1, 0, 1, 0, 1, 1, 1, 0];

        //pointer one will be set for the first zeroes
        int p1 = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                p1 = i;
                break;
            }

        }

        int p2 = p1 + 1;

        while (p2 < arr.Length)
        {
            if (arr[p2] != 0)
            {
                (arr[p1], arr[p2]) = (arr[p2], arr[p1]);
                p1++;
                p2++;
            }
            else
            {

                p2++;
            }
        }
        Console.Write("Move Zeroes to Right: ");
        Console.WriteLine(String.Join(',', arr));
    }
}

