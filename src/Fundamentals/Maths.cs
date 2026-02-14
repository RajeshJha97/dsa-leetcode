namespace Fundamentals;

internal static class Maths
{
    /// <summary>
    /// It will calculate the number of digits using logarithms to calculate length    
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
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
}
