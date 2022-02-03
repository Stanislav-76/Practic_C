// Найти максимальное из трёх чисел.
Console.WriteLine("Введите число 1: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int n3 = int.Parse(Console.ReadLine());
int max = n1;
if (max < n2) max = n2;
if (max < n3) max = n3;
Console.WriteLine("Максимальное число = " + max);