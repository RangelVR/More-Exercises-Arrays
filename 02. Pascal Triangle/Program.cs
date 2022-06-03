using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] triangle = new long[n][];

            for (int i = 0; i < n; i++)
            {
                long[] row = new long[i + 1];
                row[0] = 1;
                row[i] = 1;

                for (int j = 1; j < i; j++)
                {
                    row[j] = triangle[i - 1][j] + triangle[i - 1][j - 1];
                }
                triangle[i] = row;
            }
            foreach (var row in triangle)
            {
                Console.WriteLine(string.Join(" ", row));
            }
           
            //for (int i = 0; i < triangle.Length; i++)
            //{
            //    Console.WriteLine(string.Join(" ", triangle[i]));
            //}
        }
    }
}
