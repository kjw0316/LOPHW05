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

            int input = int.Parse(Console.ReadLine());

            int[] numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

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