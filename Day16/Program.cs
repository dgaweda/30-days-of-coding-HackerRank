using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();
        
        try
        {
            var converted = Convert.ToInt32(S);
            Console.WriteLine(converted);
        }catch (Exception e)
        {
            Console.WriteLine("Bad String");
        }
    }
}