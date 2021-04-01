using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Solution
{
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        for (int i = 0; i < input; i++)
        {
            string[] data = Console.ReadLine().Split(' ');
            phoneBook.Add(data[0], data[1]);
        }

        string name;
        while((name = Console.ReadLine()) != null)
        {
            if (phoneBook.ContainsKey(name))
                Console.WriteLine(name + "=" + phoneBook[name]);
            else
                Console.WriteLine("Not found");
        }
    }
}
