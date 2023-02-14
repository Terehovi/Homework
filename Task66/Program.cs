Console.Write("Введите 1 натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = SummOfNumbers(number1, number2);
Console.WriteLine(result);

int SummOfNumbers(int num1, int num2)
{
    if (num1 > num2) return 0;
    return num1 + SummOfNumbers(num1 + 1, num2);
}
