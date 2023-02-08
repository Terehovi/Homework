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

void FindNumberByIndex(int[,] matrix, int index1, int index2)
{
    if (index1 > matrix.GetLength(0) || index2 > matrix.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
        return;
    }
    if (index1 < 0 || index2 < 0)
    {
        Console.WriteLine("Такого элемента нет");
        return;
    } 
    else
    {
        Console.WriteLine(matrix[index1, index2]);
        return;
    } 
}
Console.WriteLine("Введите индексы числа:");
int findingIndex1 = Convert.ToInt32(Console.ReadLine());
int findingIndex2 = Convert.ToInt32(Console.ReadLine());
int[,] matr = GenerateMatrix(4, 3, 0, 10);
PrintMatrix(matr);
FindNumberByIndex(matr, findingIndex1, findingIndex2);