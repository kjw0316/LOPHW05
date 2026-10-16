using System;

namespace NumArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int evenNum = 0;
            int oddNum = 0;
            int maxNum = 0;

            int input;
            int[] numArray;

            while (true)
            {
                input = int.Parse(Console.ReadLine());
                if (input >= 1 && input <= 1000)
                    break;
                else
                    Console.WriteLine($"다시 입력하세요.");
            }
            while (true)
            {
                numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for(int i = 0; i < numArray.Length; i++)
                {
                    if (numArray[i] <= 10000 && numArray[i] >= -10000)
                    {
                        break;
                    }
                }
                if (numArray.Length == input)
                    break;
                else
                    Console.WriteLine($"다시 입력하세요.");
            }


            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] % 2 == 0)
                    evenNum++;
                else
                    oddNum++;
                if (numArray[i] > maxNum)
                    maxNum = numArray[i];
            }
            Console.Write($"{evenNum} {oddNum} {maxNum}");
        }
    }
}