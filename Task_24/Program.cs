// Найти кубы чисел от 1 до N
Console.WriteLine("Введите число от 1: ");
int n = int.Parse(Console.ReadLine());
for (int count = 1; count <= n; count++) Console.Write(count*count*count + "  ");