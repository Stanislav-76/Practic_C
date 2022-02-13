// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Задайте номер четверти от 1 до 4: ");
int x = int.Parse(Console.ReadLine());
if (x == 1) Console.WriteLine($"Диапазон координат: X = от 1 до {int.MaxValue}, Y = от 1 до {int.MaxValue}");
if (x == 2) Console.WriteLine($"Диапазон координат: X = от -1 до {int.MinValue}, Y = от 1 до {int.MaxValue}");
if (x == 3) Console.WriteLine($"Диапазон координат: X = от -1 до {int.MinValue}, Y = от -1 до {int.MinValue}");
if (x == 4) Console.WriteLine($"Диапазон координат: X = от 1 до {int.MaxValue}, Y = от -1 до {int.MinValue}");