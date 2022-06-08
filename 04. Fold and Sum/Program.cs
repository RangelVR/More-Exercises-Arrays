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
                int[] arrLefRight = new int[inputArr.Length / 2];
                int[] arrMidle = new int[inputArr.Length / 2];
                
                int stopIndex1 = inputArr.Length / 4;
                int stopIndex2 = inputArr.Length - stopIndex1;
                int counter1 = stopIndex1 - 1;
                int counter2 = stopIndex1;

                for (int i = 0; i < stopIndex1 ; i++)
                {                    
                    arrLefRight[counter1] = inputArr[i];
                    counter1--;
                }
                for (int j = inputArr.Length - 1; j >= stopIndex2; j--)
                {                    
                    arrLefRight[counter2] = inputArr[j];
                    counter2++;
                }
                for (int i = 0; i <= arrMidle.Length -1; i++)
                {
                    arrMidle[i] = inputArr[stopIndex1];
                    stopIndex1++;
                }
                for (int i = 0; i < sumArr.Length; i++)
                {
                    sumArr[i] = arrLefRight[i] + arrMidle[i];
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


//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//        int[] leftFold = new int[inputArray.Length / 4];
//        int[] rightFold = new int[inputArray.Length / 4];
//        int[] resultArray = new int[inputArray.Length / 2];

//        //Fold LEFT and RIGHT side
//        for (int i = 0; i < (inputArray.Length / 4); i++)
//        {
//            leftFold[i] = inputArray[(inputArray.Length / 4) - 1 - i];
//            rightFold[i] = inputArray[inputArray.Length - 1 - i];
//        }

//        //SUM
//        for (int i = 0; i < (inputArray.Length / 4); i++)
//        {
//            resultArray[i] = leftFold[i] + inputArray[inputArray.Length / 4 + i];
//            resultArray[inputArray.Length / 4 + i] = rightFold[i] + inputArray[inputArray.Length / 2 + i];
//        }

//        Console.WriteLine(string.Join(" ", resultArray));
//    }
//}


//using System;
//using System.Linq;

//namespace _04.FoldAndSum
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = Console.ReadLine()
//                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
//                .Select(int.Parse)
//                .ToArray();

//            int foldPoint = arr.Length / 2 / 2;

//            int[] resultArr = new int[foldPoint * 2];

//            for (int i = 0; i < foldPoint; i++)
//            {
//                resultArr[i] = arr[i + foldPoint] + arr[foldPoint - 1 - i];

//                resultArr[i + foldPoint] = arr[i + 2 * foldPoint] + arr[arr.Length - 1 - i];

//            }

//            Console.WriteLine(String.Join(' ', resultArr));
//        }
//    }
//}
