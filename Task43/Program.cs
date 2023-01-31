void CoordinatesOfIntersection(double a1, double c1, double a2, double c2)
{
    double[] coordinates = new double[2];
    for (double x1 = -10; x1 >= -10 && x1 <= 10; x1++)
    {
        double y1 = a1 * x1 + c1;
        for (double x2 = -10; x2 >= -10 && x2 <= 10; x2++)
        { 
            double y2 = a2 * x2 + c2;
            if (x1 == x2 && y1 == y2)
            {
                coordinates[0] = x1;
                coordinates[1] = y1;
            }
        }
    }
    Console.Write($"Координаты точки пересечения: ({coordinates[0]}, {coordinates[1]})");
}
Console.Write("Введите значение параметра k1 для y1 = k1 * x + b1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение параметра b1 для y1 = k1 * x + b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение параметра k2 для y2 = k2 * x + b2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение параметра b2 для y2 = k2 * x + b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
CoordinatesOfIntersection(k1, b1, k2, b2);