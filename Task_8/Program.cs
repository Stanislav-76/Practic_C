// Показать чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int N = 2;
Console.WriteLine("Четные числа от 1 до " + number);
while (N <= number)
{
    Console.Write(N + " ");
    N = N + 2;
}