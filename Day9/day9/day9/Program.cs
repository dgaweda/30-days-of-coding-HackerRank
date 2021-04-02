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

class Solution
{

    // Complete the factorial function below.
    static int factorial(int n)
    {
        if (n == 1)
            return 1; // stop point
        else
            return n * factorial(n - 1); // recursion

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine()); // convert to int

        int result = factorial(n); // using method

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
