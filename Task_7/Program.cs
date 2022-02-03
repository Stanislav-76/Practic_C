// Показать числа от -N до N
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int N = - number;
Console.WriteLine($"Числа от {- number} до {number}");
while (N <= number)
{
    Console.Write(N + " ");
    N = N + 1;
}