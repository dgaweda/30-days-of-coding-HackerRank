using System;
using Day19;

namespace Day19
{
    class Solution
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            IAdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            int sum2 = myCalculator.DivisorSumLoop(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum + "\nLoop: "+ sum2);
        }
    }
}