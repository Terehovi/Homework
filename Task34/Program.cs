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
int FindEvenNumber(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) counter++;
    }
    return counter;
}

int[] array = GenerateArray(12, 100, 999);
PrintArray(array);
Console.Write(" -> ");
int evenNumbers = FindEvenNumber(array);
Console.Write(evenNumbers);