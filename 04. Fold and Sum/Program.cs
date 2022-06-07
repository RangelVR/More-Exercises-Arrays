using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] sumArr = new int[inputArr.Length / 2];


            if (inputArr.Length > 4)
            {
                int[] arr1 = new int[inputArr.Length / 2];
                int[] arr2 = new int[inputArr.Length / 2];
                
                int stopIndex1 = inputArr.Length / 4;
                int stopIndex2 = inputArr.Length - stopIndex1;
                int counter1 = stopIndex1 - 1;
                int counter2 = stopIndex1;

                for (int i = 0; i < stopIndex1 ; i++)
                {
                    
                    arr1[counter1] = inputArr[i];
                    counter1--;
                }
                for (int j = inputArr.Length - 1; j >= stopIndex2; j--)
                {
                    
                    arr1[counter2] = inputArr[j];
                    counter2++;
                }
                for (int i = 0; i <= arr2.Length -1; i++)
                {
                    arr2[i] = inputArr[stopIndex1];
                    stopIndex1++;
                }
                for (int i = 0; i < sumArr.Length; i++)
                {
                    sumArr[i] = arr1[i] + arr2[i];
                }
            }
            else
            {
                sumArr[0] = inputArr[0] + inputArr[1];
                sumArr[1] = inputArr[2] + inputArr[3];
            }
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
