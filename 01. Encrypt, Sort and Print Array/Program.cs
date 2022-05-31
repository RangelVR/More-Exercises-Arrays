using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] output = new int[n];

            for (int i = 0; i < n; i++)
            {
                string inputString = Console.ReadLine();
                int sum = 0;
                foreach (var letter in inputString)
                {
                    switch (letter)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                            sum += letter * inputString.Length;
                            break;
                        default:
                            sum += letter / inputString.Length;
                            break;
                    }
                }
                output[i] = sum;
            }
            Array.Sort(output);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            //foreach (var item in output.OrderBy(x => x))
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
