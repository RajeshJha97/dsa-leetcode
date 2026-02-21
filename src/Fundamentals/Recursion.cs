namespace Fundamentals;

internal class Recursion
{
    public static void ReverseArray(int[] arr, int start, int end)
    {
        if (start >= end)
            return;

        int temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;

        ReverseArray(arr, start + 1, end - 1);
    }
    public static int Factorial(int n)
    {
        if (n > 0)
        {
            return n * Factorial(n - 1);
        }
        return 1;
    }
    public static int SumofNNaturalNumber(int n)
    {
        if (n > 0)
        {
            return n + SumofNNaturalNumber(n - 1);
        }
        return 0;
    }
    public static void PrintNto1_HeadRecusrion(int n, int limiter)
    {
        if (n >= limiter)
        {
            PrintNto1_HeadRecusrion(n, limiter + 1);
            Console.Write($"{limiter} ");
        }
        return;
    }
    public static void PrintNto1_TailRecusrion(int n)
    {
        if (n > 0)
        {
            Console.Write($"{n} ");
            PrintNto1_TailRecusrion(n - 1);
        }
        return;
    }
    public static void Print1ToN_HeadRecusrion(int n)
    {
        if (n > 0)
        {
            Print1ToN_HeadRecusrion(n - 1);
            Console.Write($"{n} ");
        }
        return;
    }
    public static void Print1ToN_TailRecusrion(int start, int n)
    {
        if (start <= n)
        {
            Console.Write($"{start} ");
            Print1ToN_TailRecusrion(start + 1, n);
        }
        return;
    }
    public static void PrintNameNTimes(int n)
    {
        if (n > 0)
        {
            Console.Write("Rajesh ");
            PrintNameNTimes(n - 1);
        }
        return;
    }
}
