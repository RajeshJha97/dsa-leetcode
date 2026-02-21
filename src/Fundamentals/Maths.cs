namespace Fundamentals;

internal static class Maths
{
    public static bool IsArmstrong(int n)
    {
        int length = n.ToString().Length;
        int orig = n;
        int arms = 0;

        while (n > 0)
        {
            int lastDigit = n % 10;
            arms = arms + (int)Math.Pow(lastDigit, length);
            n = n / 10;
        }

        if (arms == orig)
        {
            return true;
        }

        return false;
    }
    public static int GCDEuclidAlgo(int n1, int n2)
    {
        while (n1 != 0 && n2 != 0)
        {
            if (n2 > n1)
            {
                n2 = n2 % n1;
            }
            else
            {
                n1=n1 % n2;
            }
        }

        if (n1 == 0)
        {
            return n2;
        }
        else 
        {
            return n1;
        }
    }
    public static int GCDBruteForce(int n1, int n2)
    {
        int gcd = 1;
        int smallest = n1 > n2 ? n2 : n1;

        for (int i = 1; i <= smallest; i++)
        {
            if (n1 % i == 0 && n2 % i == 0)
            {
                if (i > gcd)
                {
                    gcd = i;
                }
            }
        }

        return gcd;
    }
    public static int CountDigitsInANumber(int number)
    {
        /*
            Example 1:
            Input:N = 12345
            Output:5
            Explanation:  The number 12345 has 5 digits.
                        
            Example 2:
            Input:N = 7789              
            Output: 4
            Explanation: The number 7789 has 4 digits. 
         */

        int cnt = 0;

        if (number == 0)
            return 0;

        if (number < 0)
            number = -number;
     
        cnt = (int)Math.Floor(Math.Log10(number));

        return cnt;

        //Brute Force
        /*
        int cnt = 0;
       
        while (number > 0)
        {
            number = number / 10;
            cnt++;
        }

        return cnt;
        */
    }
    public static int ReverseNumber(int number)
    {
        int reverse = 0;
        while(number>0)
        {
            int lastDigit = (number % 10);
            reverse = reverse * 10 + lastDigit;
            number = number / 10;
        }

        return reverse;
    }
    public static bool IsPallindrome(int number)
    {
        int orig = number;
        int reverse = 0;
        while (number > 0)
        {
            reverse = reverse * 10 + number % 10;
            number = number / 10;
        }

        if (orig == reverse)
        {
            return true;
        }
        return false;
    }
}
