// Показать натуральные числа от M до N, N и M заданы
int m = 4;
int n = 9;
int function(int x, int y)
{
    if (x == y) return x;
    Console.Write(x + " ");
    return function(x + 1, y);
}
Console.Write(function(m, n));