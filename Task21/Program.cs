double Distance(int a1, int a2, int b1, int b2, int c1, int c2)
{
    return Math.Sqrt(Math.Pow((a2-a1), 2) + Math.Pow((b2-b1), 2) + Math.Pow((c2-c1), 2));
}

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, x2, y1, y2, z1, z2);
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine(distanceRound);