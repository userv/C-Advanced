using System;
using System.Linq;



public class DiagonalDifference
{
    public static void Main()
    {
        int matrixSize = int.Parse(Console.ReadLine());
        int[][] matrix = new int[matrixSize][];
        for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
        {
            matrix[rowIndex] = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
        int primaryDiagonalSum = 0;
        int secondaryDiagonalSum = 0;

        for (int i = 0; i < matrix.Length; i++)
        {
            primaryDiagonalSum += matrix[i][i];
            secondaryDiagonalSum += matrix[(matrix.Length - 1) - i][i];
        }
        Console.WriteLine(Math.Abs(primaryDiagonalSum-secondaryDiagonalSum));
    }
}
