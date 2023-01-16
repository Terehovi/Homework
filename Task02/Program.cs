// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Write("Введите 1 целое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 целое число ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 > num1)
{
    Console.WriteLine($"Ответ: {num2}");
}
else
{
    Console.WriteLine($"Ответ: {num1}");
}