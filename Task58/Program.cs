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
int[,] ProductOfMatrixes(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int l = 0; l < matrix2.GetLength(1); l++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    if (j == k) matrix3[i, l] += matrix1[i, j] * matrix2[k, l];
                }
            }
        }
    }
    return matrix3;
}

int[,] matr1 = GenerateMatrix(2, 2, 0, 10);
int[,] matr2 = GenerateMatrix(2, 2, 0, 10);
PrintMatrix(matr1);
PrintMatrix(matr2);
int[,] resultMatrix = ProductOfMatrixes(matr1, matr2);
PrintMatrix(resultMatrix);