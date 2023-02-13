int[,] GenerateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}   |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("   |");

    }
    Console.WriteLine();
}
int FindMinimumSumInRows(int[,] matrix)
{
    int minRowSum = int.MaxValue, indexMinRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }
        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            indexMinRow = i + 1;
        }
    }
    return indexMinRow;
}

int[,] matr = GenerateMatrix(4, 3, 0, 10);
PrintMatrix(matr);
int minSumInRow = FindMinimumSumInRows(matr);
Console.WriteLine(minSumInRow);