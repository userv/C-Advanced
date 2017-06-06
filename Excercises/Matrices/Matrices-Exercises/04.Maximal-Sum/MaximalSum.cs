using System;
using System.Linq;


public class MaximalSum
{
    public static void Main()
    {
        int[] matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rowsNumber = matrixSize[0];
        int colsNumber = matrixSize[1];
        int rowIndex = 0;
        int colIndex = 0;
        int maxSum = int.MinValue;
        int[][] matrix = new int[rowsNumber][];
        for (int row = 0; row < matrix.Length; row++)
        {
            matrix[row] = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
        for (int row = 0; row < matrix.Length - 2; row++)
        {
            for (int col = 0; col < matrix[0].Length - 2; col++)
            {
                int curentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                                 matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] +
                                 matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];
                if (curentSum > maxSum)
                {
                    maxSum = curentSum;
                    rowIndex = row;
                    colIndex = col;
                }
            }
        }
        Console.WriteLine($"Sum = {maxSum}");
        Console.WriteLine($"{matrix[rowIndex][colIndex]} {matrix[rowIndex][colIndex + 1]} {matrix[rowIndex][colIndex + 2]}");
        Console.WriteLine($"{matrix[rowIndex + 1][colIndex]} {matrix[rowIndex + 1][colIndex + 1]} {matrix[rowIndex + 1][colIndex + 2]}");
        Console.WriteLine($"{matrix[rowIndex + 2][colIndex]} {matrix[rowIndex + 2][colIndex + 1]} {matrix[rowIndex + 2][colIndex + 2]}");

    }
}
