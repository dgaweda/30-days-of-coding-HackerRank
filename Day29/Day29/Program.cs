using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
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
        var andResult = 0;
        var max = 0;
        var p = 1;
        
        while(p++ <= N){
            for(int s = p + 1; s <= N; s++){
                andResult = p & s;
                 if(andResult < K && andResult > max){
                     max = andResult;
                     if(max == (K-1))
                     {
                         break;
                     }
                 }
            }
        }
     
        return max;
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
