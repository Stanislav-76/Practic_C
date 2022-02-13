// Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("Задайте число от 1: ");
int n = int.Parse(Console.ReadLine());
int count = 1;
while (count <= n)
{
    Console.WriteLine($"{count}^2 = {count * count}");
    count++;
}