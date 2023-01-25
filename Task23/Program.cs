Console.Write("Введите натуральное число: ");
long number = Convert.ToInt64(Console.ReadLine());
if (number < 1) Console.WriteLine("Некорректный ввод");
else TableCubes(number);


void TableCubes(long num)
{
    long count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 5}   {count * count * count, 5}");
        count++;
    }
}