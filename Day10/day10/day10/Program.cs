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
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        var convert = Convert.ToString(n, 2); // converting from base 10 to base 2

        Console.WriteLine(CountOnes(convert));
    }

    public static int CountOnes(string n)
    {
        var end = n.Length-1;
        var count = 0;
        var temp = 0;
        for (var i = 0; i < n.Length; i++)
        {
            if(n[i].Equals('1'))
            {
                temp++;
                if (i == end && count < temp)
                    count = temp;
            }
            else
            {
                if (temp > count)
                    count = temp;
                temp = 0;
            }
                    
        }
        return count;
    }
}

