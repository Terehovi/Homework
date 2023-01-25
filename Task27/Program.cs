// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SummaDigits(int number)
{
    int sum = 0;
    if (number < 0) number *= (-1);
    else if (number == 0) return 0;
    while(number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int summa = SummaDigits(num);
Console.WriteLine($"{num} -> {summa}");
