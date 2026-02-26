using Fundamentals;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        //int number = 414;        
        //Console.WriteLine(Maths.CountDigitsInANumber(-4589));


        //Console.WriteLine($"Reverse: {Maths.ReverseNumber(number)}");
        //Console.WriteLine($"Pallindrome: {Maths.IsPallindrome(number)}");
        //Console.WriteLine($"GCD: {Maths.GCDBruteForce(15, 30)}");
        //Console.WriteLine($"GCD Euclid: {Maths.GCDEuclidAlgo(15, 30)}");
        //Console.WriteLine($"ISAmrstrong: {Maths.IsArmstrong(153)}");

        //Recursion.PrintNameNTimes(3);
        //Console.WriteLine();
        //Recursion.Print1ToN_TailRecusrion(1,3);
        //Console.WriteLine();
        //Recursion.Print1ToN_HeadRecusrion(3);
        //Console.WriteLine();
        //Recursion.PrintNto1_TailRecusrion(4);
        //Console.WriteLine();
        //Recursion.PrintNto1_HeadRecusrion(4,4);
        //Console.WriteLine(Recursion.SumofNNaturalNumber(3));

        //Console.WriteLine($"Factorial of 5: {Recursion.Factorial(5)}");

        //int[] arr = { 1, 2, 3, 4, 5 };
        //Console.WriteLine("Before Reverse: ");
        //Console.WriteLine(string.Join(",", arr));
        //Recursion.ReverseArray(arr, 0, arr.Length - 1);
        //Console.WriteLine("After Reverse: ");
        //Console.Write(String.Join(",", arr));

        //Hashing.BasicDictionary();
        int[] arr1= { 8,6,3,2,5,4 };
        //Hashing.FrequencyOfEachElement(arr1);
        //Hashing.HighestLowest(arr1);

        //Sorting.BubbleSort(arr1);
        //Sorting.InsertionSort(arr1);
        Sorting.SelectionSort(arr1);
    }


}