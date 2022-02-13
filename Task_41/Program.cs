// Выяснить являются ли три числа сторонами треугольника
Console.WriteLine("Введите длину сторон треугольника: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());
if (x + y > z & x + z > y & y + z > x) Console.WriteLine("Числа являются сторонами треугольника");
else Console.WriteLine("Числа не являются сторонами треугольника");