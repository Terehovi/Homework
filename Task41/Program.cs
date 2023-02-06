string? num = string.Empty;
Console.WriteLine("Введите целые числа через пробел(более 1 пробела и любые другие символы недопускаются):");
num = Console.ReadLine();
int countValues = CountNaturalNumbers(num);
Console.WriteLine(countValues);
int CountNaturalNumbers(string? number)
{
    if (number == string.Empty) return 0;
    var data = number.Split(" ").ToArray();
    int counter = 0;
    for (int i = 0; i < data.Length; i++)
    {
        int number1 = Convert.ToInt32(data[i]);
        if (number1 > 0) counter++;
    }
    return counter;
}