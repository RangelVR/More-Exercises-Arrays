using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacciNum = int.Parse(Console.ReadLine());
            long[] fibonacciSequence = new long[50];
            fibonacciSequence[0] = 1;
            fibonacciSequence[1] = 1;

            for (int i = 2; i < fibonacciNum; i++)
            {
                fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
            }
            Console.WriteLine(fibonacciSequence[fibonacciNum - 1]);
        }
    }
}
