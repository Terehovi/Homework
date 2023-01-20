Console.Write("Введите целое трёхзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int number)
{
    number /= 10;
    number %= 10;
    return number;
}

if ((num >= 100) && (num <= 999))
{
    int secondDigit = SecondDigit(num);
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Ошибка. Пожалуйста введите целое трёхзначное число");
}
