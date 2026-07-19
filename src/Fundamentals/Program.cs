using Fundamentals.LinkedList;

internal class Program
{
    private static void Main(string[] args)
    {

        Doubly dl= new Doubly();
        dl.AddFirst(10);
        dl.AddFirst(20);
        dl.AddFirst(30);
        dl.AddAny(170, 1);
        dl.AddLast(40);
        dl.AddLast(70);
        dl.AddAny(120,2);
        dl.AddAny(120, 12);
        dl.Display();

        //Circular cl=new Circular();
        //cl.AddLast(10);
        //cl.AddLast(20);
        //cl.AddLast(30);
        //cl.AddLast(40);
        //cl.AddLast(50);
        //cl.AddFirst(60);
        //cl.AddFirst(70);
        //cl.AddAny(90,4);
        //cl.Display();
        //Console.ForegroundColor = ConsoleColor.DarkMagenta;
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
        int[] arr = { 8, 6, 3, 2, 5, 4 };
        //Hashing.FrequencyOfEachElement(arr1);
        //Hashing.HighestLowest(arr1);

        //Sorting.BubbleSort(arr1);
        //Sorting.InsertionSort(arr1);
        //Sorting.SelectionSort(arr);
        int[] arr1 = { 10, 12, 15 };
        int[] arr2 = { 10, 15, 18, 20 };

        //Sorting.MergeSortedArray(arr1, arr2);

        //CustomLinkedList l1 = new CustomLinkedList();
        //l1.AddLast(10);
        //l1.AddLast(20);
        //l1.AddLast(30);
        //l1.AddLast(40);
        //l1.AddLast(50);

        //l1.AddFirst(10);
        //l1.AddFirst(20);
        //l1.AddFirst(30);
        //l1.AddLast(40);
        //l1.AddLast(50);
        //l1.AddFirst(60);
        //l1.AddAny(70, 3);
        //l1.Display();

        //Console.WriteLine("Rmoving First: ");
        //l1.RemoveFirst();
        //l1.Display();

        //Console.WriteLine("Rmoving Any: ");
        //l1.RemoveAny(2);
        //l1.Display();
    }


}