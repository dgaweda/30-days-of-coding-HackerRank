using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


class Solution
{
    public static void Main(string[] args)
    {
        List<string> names = new List<string>();
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        for (int i = 0; i < n; i++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            string firstName = firstMultipleInput[0];
            string emailID = firstMultipleInput[1];
            var checkedName = CheckName(firstName).ToString();
            var checkedEmail = CheckEmail(emailID).ToString();
            
            if (firstName.Equals(checkedName) && emailID.Equals(checkedEmail))
            {
                names.Add(firstName);
            }
        }
        
        names.Sort();
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }

    private static object CheckName(string name)
    {
        string regExName = @"([a-z])\w+";

        return Regex.Match(name, regExName);
    }

    private static object CheckEmail(string email)
    {
        string regExEmail = @"([a-z])\w+(.)+([a-z])(@)+(gmail)+(.)+(com)";
        
        return Regex.Match(email, regExEmail);
    }
}