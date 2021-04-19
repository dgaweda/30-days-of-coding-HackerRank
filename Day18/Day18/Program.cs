/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Day18
{
    class Program
    {
        public static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var Spop = "";
            var Qdequeue = "";
            Stack<char> stack = new Stack<char>(); // STOS: Pop, Push, Peek(zwraca element ale go nie usuwa ze stosu)
            Queue<char> queue = new Queue<char>(); // KOLEJKA: Enqueue, Dequeue, Peek(zwraca najstarszy element ale go nie usuwa)

            foreach (char c in s)
            {
                stack.Push(c);
                queue.Enqueue(c);
            }

            foreach (char c in s)
            {
                Spop += stack.Pop().ToString();
                Qdequeue += queue.Dequeue().ToString();
            }

            if (Spop.Equals(Qdequeue))
            {
                Console.WriteLine($"{s} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{s} is not a palindrome");
            }
        }
    }
}*/