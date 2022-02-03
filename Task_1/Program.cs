// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите число 1: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int n2 = int.Parse(Console.ReadLine());
if (n1 == n2*n2)
{
    Console.WriteLine("Число 1 является квадратом числа 2");
}
else
{
    Console.WriteLine("Число 1 не является квадратом числа 2");
}