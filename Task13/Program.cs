Console.Write("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());

int ThreeDigits(int number)
{
    if (number / 100 != 0) return 1;
    else return 0;
}
int threeDigits = ThreeDigits(num);

while (num / 1000 != 0)
{
    num /= 10;
}

if (threeDigits == 0) Console.WriteLine("Третьей цифры нет");
else
{
    num %= 10;
    Console.WriteLine(num);
}