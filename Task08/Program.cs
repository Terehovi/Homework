// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите целое положительное число ");
int N = Convert.ToInt32(Console.ReadLine());
int counter = 1;
if (N > 0)
{
    while (counter <= N)
    {
        if (counter % 2 == 0)
        {
            Console.Write($"{counter} ");
            counter++;
        }
        else
        {
            counter++;
        }
    }
}
else
{
    Console.WriteLine("Ошибка. Введите целое положительное число");
}