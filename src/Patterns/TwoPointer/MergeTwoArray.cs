using System.Runtime.CompilerServices;

namespace TwoPointer;

internal static class MergeTwoArray
{

    public static void Merge()
    {
        char[] arr1 = ['a', 'b', 'c'];
        char[] arr2 = ['1', '2', '3', '4', '5', '6'];

        char[] resp = new char[arr1.Length + arr2.Length];

        int p1 = 0; //arr1 pointer
        int p2 = 0; //arr2 pointer
        int p3 = 0; //resp pointer

        while (p3 < resp.Length)
        {
            if (p1 < arr1.Length)
            {
                resp[p3] = arr1[p1];
                p3++;
                p1++;
            }

            if (p2 < arr2.Length)
            {
                resp[p3] = arr2[p2];
                p3++;
                p2++;
            }
        }


        Console.WriteLine(String.Join(',', resp));
        return;

    }
   
}
