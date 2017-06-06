using System;
using System.Linq;


public class MatrixOfPalindromes
{
    public static void Main()
    {
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        int[] matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rowsNumber = matrixSize[0];
        int colsNumber = matrixSize[1];
        string[][] matrix = new string[rowsNumber][];
        for (int row = 0; row < rowsNumber; row++)
        {
            matrix[row] = new string[colsNumber];
            for (int col = 0; col < colsNumber; col++)
            {
                string currentElement = $"{alphabet[row]}{alphabet[row + col]}{alphabet[row]}";
                matrix[row][col] = currentElement;
            }
        }
        for (int row = 0; row < matrix.Length; row++)
        {
            Console.WriteLine(string.Join(" ", matrix[row]));
        }
    }
}

