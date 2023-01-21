int num = Convert.ToInt32(Console.ReadLine());
if (num >= 10000 && num <= 99999)
{
    if (num / 10000 == num % 10)
    {
        num /= 10;
        num %= 1000;
        if (num / 100 == num % 10)
        {
            Console.WriteLine("Да");
        }
        else Console.WriteLine("Нет");
    }
    else Console.WriteLine("Нет");
} 
else Console.WriteLine("Некоректный ввод");