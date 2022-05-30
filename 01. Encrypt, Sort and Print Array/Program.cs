using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());           

            for (int i = 0; i < n; i++)
            {
                string inputString = Console.ReadLine();
                int sum = 0;

                foreach (var letter in inputString)
                {
                    if (Char.IsLower(letter))
                    {
                        switch (letter)
                        {
                            case 'a':
                            case 'e':
                            case 'i':
                            case 'o':
                            case 'u':
                                sum += letter * inputString.Length;
                                break;
                            default:
                                sum += letter / inputString.Length;
                                break;
                        }
                    }
                    else if (Char.IsUpper(letter))
                    {
                        switch (letter)
                        {
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
                }
                Console.WriteLine(sum);
            }
            
        }
    }
}
