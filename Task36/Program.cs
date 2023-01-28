int[] GenerateArray(int size, int min, int max)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(min, max);
    }
return arr;
}
void PrintArray(int[] arr)
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
int SumNotEvenIndexNumbers(int[] arr)
{
    int summa = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) summa += arr[i];
    }
    return summa;
}

int[] array = GenerateArray(8, 0, 100);
PrintArray(array);
int sum = SumNotEvenIndexNumbers(array);
Console.Write(" -> ");
Console.Write(sum);