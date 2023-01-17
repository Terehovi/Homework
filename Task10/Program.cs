Console.Write("Введите целое трёхзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int number)
{
    number /= 10;
    number %= 10;
    return number;
}

int secondDigit = SecondDigit(num);
Console.WriteLine(secondDigit);