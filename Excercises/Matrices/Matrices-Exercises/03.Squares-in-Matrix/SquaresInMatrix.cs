using System;
using System.Linq;



public class SquaresInMatrix
{
    public static void Main(string[] args)
    {
        int[] matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rowsNumber = matrixSize[0];
        int colsNumber = matrixSize[1];
        int numberOfSquares = 0;
        string[][] matrix = new string[rowsNumber][];
        for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
        {
            matrix[rowIndex] = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
        }
        for (int rowIndex = 0; rowIndex < matrix.Length - 1; rowIndex++)
        {
            for (int colIndex = 0; colIndex < matrix[0].Length - 1; colIndex++)
            {

                if (matrix[rowIndex][colIndex] == matrix[rowIndex][colIndex + 1] &&
                    matrix[rowIndex][colIndex + 1] == matrix[rowIndex + 1][colIndex] &&
                    matrix[rowIndex + 1][colIndex] == matrix[rowIndex + 1][colIndex + 1])
                {
                    numberOfSquares++;
                }
            }
        }
        Console.WriteLine(numberOfSquares);
    }
}

