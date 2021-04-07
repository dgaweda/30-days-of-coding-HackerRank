using System;

namespace day11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            Console.WriteLine(Sum(arr));
        }

        public static int Sum(int[][] arr)
        {
            var stop = (arr.Length / 2);                                                // Setting STOP of Loops
            var tempSum = 0;                                                            // Temporary Sum (inside loop)
            var sum = 0;                                                                // final sum
            for (var i = 0; i <= stop; i++)                                             // First Loop (y) | (x , y) = array2d
            {
                for (var j = 0; j <= stop; j++)                                         // Second Loop (x) | (x , y) = array2d
                {
                    tempSum += arr[i][j] + arr[i][j + 1] + arr[i][j + 2];               // first peace of clepsydra "THE ROOF"
                    tempSum += arr[i + 1][j + 1];                                       // the middle of clepsydra - MID
                    tempSum += arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];   // The Floor            
                    if ((i == 0 && j == 0) || tempSum > sum)
                    {
                        sum = tempSum;
                    }

                    tempSum = 0;
                }
            }

            return sum;
        }
    }
}
