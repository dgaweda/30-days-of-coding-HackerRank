using System;

namespace Day20
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] temp_arr = Console.ReadLine().Split(' ');
            int[] values = Array.ConvertAll(temp_arr, Int32.Parse);
            values = BubbleSort(values);
            
            foreach(var i in values)
                Console.Write(i);
        }

        public static int[] BubbleSort(int[] arr)
        {
            var temp = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = 0; j < arr.Length-1; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }
    }
}