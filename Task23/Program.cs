Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Некорректный ввод");
else TableCubes(number);


void TableCubes(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 5}   {count * count * count, 5}");
        count++;
    }
}