Console.Write("Введите цифру то 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
// if ((num == 6) || (num == 7))
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

bool DayOfWeek(int number)
{
    return ((num == 6) || (num == 7));
}
if ((num >= 1) && (num <= 7))
{
    bool dayOfWeek = DayOfWeek(num);
    if (dayOfWeek == true) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Ошибка. Пожалуйста введите цифру то 1 до 7");