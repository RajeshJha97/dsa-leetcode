using System.Collections.Generic;

namespace Fundamentals;

internal static class Hashing
{
    public static void HighestLowest(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("Array is empty");
            return;
        }

        Dictionary<int, int> frequencies = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (frequencies.ContainsKey(arr[i]))
            {
                frequencies[arr[i]] = frequencies[arr[i]] + 1;
            }
            else
            {
                frequencies[arr[i]] = 1;
            }
        }

        int maxElement=arr[0];
        int maxValue=int.MinValue;
        int minElement=arr[0];
        int minValue=int.MaxValue;

        foreach (var frequency in frequencies)
        {
            if (frequency.Value > maxValue)
            {
                maxValue = frequency.Value;
                maxElement = frequency.Key;
            }
            if (frequency.Value < minValue)
            {
                minValue = frequency.Value;
                minElement = frequency.Key;
            }
        }

        Console.WriteLine($"Max: {maxElement}:{maxValue}");
        Console.WriteLine($"Min: {minElement}:{minValue}");

    }
    public static void FrequencyOfEachElement(int[] arr)
    {
        Dictionary<int, int> frequencies = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (frequencies.ContainsKey(arr[i]))
            {
                frequencies[arr[i]] += 1;
            }
            else 
            {
                frequencies[arr[i]] = 1;
            }
        }

        foreach (var frequency in frequencies)
        {
            Console.WriteLine($"{frequency.Key}:{frequency.Value}");
        }
    }

    public static void BasicDictionary()
    {
        Dictionary<string, int> UserName_Age = new Dictionary<string, int>();

        UserName_Age["Rajesh"] = 29;
        UserName_Age["Kajal"] = 30;
        //Dictionary: is a collection of key and value pair there can be multiple key value pair
        //KeyValuePair: can have only 1 key and value
        KeyValuePair<string, int> name = new KeyValuePair<string, int>("Rajesh", 30);

        var checkName=UserName_Age.Contains(name);
        foreach (KeyValuePair<string,int> item in UserName_Age)
        {
            Console.WriteLine($"{item.Key}:{item.Value}");
        }
    }
}
