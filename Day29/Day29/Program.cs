using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Result
{

    /*
     * Complete the 'bitwiseAnd' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER N - List With N Size
     *  2. INTEGER K - Limit after A&B operation
     */

    public static int bitwiseAnd(int N, int K)
    {
        var j = 1;
        var andResult = 0;
        var integers = new int[N];
        var andResults = new List<int>();
        var finalResult = 0;
        for (var i = 0; i < N; i++) // filling tab
        {
            integers[i] = j;
            j++;
        }

        for (var k = 1; k < integers.Length; k++)
        {
            for (var l = 2; l <= integers.Length; l++)
            {
                andResult = integers[k] & l;
                if (!andResults.Contains(andResult))
                {
                    andResults.Add(andResult);
                }
            }
        }

        var sortedList = andResults.OrderByDescending(x => x).ToList();
        foreach (var elem in sortedList)
        {
            if (elem < K)
            {
                finalResult = elem;
                break;
            }
        }

        return finalResult;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int count = Convert.ToInt32(firstMultipleInput[0]);

            int lim = Convert.ToInt32(firstMultipleInput[1]);

            int res = Result.bitwiseAnd(count, lim);

            textWriter.WriteLine(res);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}