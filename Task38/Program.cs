double[] GenerateArray(int size, int min, int max)
{
    Random rand = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.NextDouble() * (max - min) + min, 1);
    }
return arr;
}
void PrintArray(double[] arr)
{
    int i = 0;
    Console.Write("[");
    while (i < arr.Length)
    {
        if (i == arr.Length - 1) Console.Write($"{arr[i]}");
        else if (i < arr.Length) Console.Write($"{arr[i]}" + ", ");
        i++;
    }
    Console.Write("]");
}
double MaxNumber(double[] arr)
{
    int i = 0;
    double max = arr[i];
    while (i < arr.Length)
    {
        if (arr[i] > max) max = arr[i];
        i++;
    }
    return Math.Round(max, 1);
}
double MinNumber(double[] arr)
{
    int i = 0;
    double min = arr[i];
    while (i < arr.Length)
    {
        if (arr[i] < min) min = arr[i];
        i++;
    }
    return Math.Round(min, 1);
}

double[] array = GenerateArray(6, 0, 100);
PrintArray(array);
Console.Write(" -> ");
double maximum = MaxNumber(array);
double minimum = MinNumber(array);
Console.Write(Math.Round(maximum - minimum, 1));