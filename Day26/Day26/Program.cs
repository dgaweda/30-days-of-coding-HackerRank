using System;

class Solution {
    static void Main(String[] args)
    {
        string[] returnDate = Console.ReadLine().Split(' ');
        string[] dueDate = Console.ReadLine().Split(' ');
        // 0 - day
        // 1 - month
        // 2 - year
        var returnDateInt = ConvertToInt(returnDate);
        var dueDateInt = ConvertToInt(dueDate);
        
        Console.WriteLine(CheckFine(returnDateInt, dueDateInt));
    }

    private static int[] ConvertToInt(string[] tab)
    {
        var convertedTab = new int[tab.Length];
        for (var i = 0; i < tab.Length; i++)
        {
            convertedTab[i] = Convert.ToInt32(tab[i]);
        }
        return convertedTab;
    }

    private static int CheckFine(int[] returnDateInt, int[] dueDateInt)
    {
        var fine = 0;
        if (returnDateInt[2] > dueDateInt[2])
        {
            fine = 10000;
        }
        else if (returnDateInt[2] == dueDateInt[2] && returnDateInt[1] > dueDateInt[1])
        {
            fine = (returnDateInt[1] - dueDateInt[1]) * 500;
        }
        else if (returnDateInt[1] == dueDateInt[1] && returnDateInt[2] == dueDateInt[2])
        {
            if (returnDateInt[0] > dueDateInt[0])
            {
                fine = (returnDateInt[0] - dueDateInt[0]) * 15;
            }
        }

        return fine;
    }
}