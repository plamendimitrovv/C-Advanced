using System.Linq;
using System;

namespace _3._Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse).ToArray();

            int[] sizes = new int[3];

            foreach (var number in numbers)
            {
                sizes[Math.Abs(number % 3)]++;
            }

            int[][] jagged = new int[3][];

            for (int i = 0; i < sizes.Length; i++)
            {
                jagged[i] = new int[sizes[i]];
            }

            int[] index = new int[3];

            foreach (var number in numbers)
            {
                var remainder = Math.Abs(number % 3);
                jagged[remainder][index[remainder]] = number;
                index[remainder]++;
            }

            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jagged[i]));
            }
        }
    }
}
