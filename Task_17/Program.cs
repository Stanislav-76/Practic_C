// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите число 1: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int n2 = int.Parse(Console.ReadLine());
if (n1 == n2*n2 || n1*n1 == n2)
{
    Console.WriteLine("Одно из чисел является квадратом другого числа");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого числа");
}