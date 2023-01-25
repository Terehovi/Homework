// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] GenerateArray()
{
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(int.MinValue, int.MaxValue);
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


int [] array = GenerateArray();
PrintArray(array);