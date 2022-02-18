// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
double k1 = 2, b1 = 3, k2 = 4, b2 = 5;
if (k1 == k2) Console.WriteLine("Прямые не пересекаются.");
else 
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения прямых ({x};{y})");
}