// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

bool Natural(int number1)
{
    return (number1 > 0);
}

Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите натуральную степень: ");
int num1 = Convert.ToInt32(Console.ReadLine());
bool natural = Natural(num1);
if (natural == true)
{
    int counter = 1;
    double result = 1;
    while (counter <= num1)
    {
        result *= num;
        counter++;
    }
    Console.Write($"{num}, {num1} -> {result}");
}
else Console.Write("Некорректный ввод");

