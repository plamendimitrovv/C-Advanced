using System;
using System.Linq;

namespace _2._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndColumns = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndColumns[0], rowsAndColumns[1]];

            for (int rows = 0; rows < rowsAndColumns[0]; rows++)
            {
                var rowValues = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int columns = 0; columns < rowsAndColumns[1]; columns++)
                {
                    matrix[rows, columns] = rowValues[columns];
                }
            }

            int maxSum = int.MinValue;
            int rowindex = 0;
            int columnIndex = 0;

            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1) - 1; columns++)
                {
                    var currentSum = matrix[rows, columns] + matrix[rows, columns + 1] + matrix[rows + 1, +columns] + matrix[rows + 1, columns + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        rowindex = rows;
                        columnIndex = columns;
                    }
                }
            }

            Console.WriteLine($"{matrix[rowindex,columnIndex]} {matrix[rowindex, columnIndex + 1]}");
            Console.WriteLine($"{matrix[rowindex + 1, columnIndex]} {matrix[rowindex + 1, columnIndex + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
