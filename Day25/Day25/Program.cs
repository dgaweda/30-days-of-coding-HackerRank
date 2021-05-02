using System;

class Solution {
    static void Main(String[] args)
    {
        int howMany = Convert.ToInt32(Console.ReadLine());
        while (0 < howMany)
        {
            IfPrime(Convert.ToInt32(Console.ReadLine()));
            howMany--;
        }
        
    }
    public static void IfPrime(int number)
    {
        if (number == 1)
        {
            Console.WriteLine("Not Prime");
            return;
        }

        for (var i = 2; i <= Math.Sqrt(number); i++)
        {
            if ((number % i) == 0)
            {
                Console.WriteLine("Not Prime");
                return;
            }
        }
        Console.WriteLine("Prime");
    }
}