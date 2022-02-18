// Показать натуральные числа от N до 1, N задано
int n = 17;
int function(int x)
{
    if (x == 1) return x;
    Console.Write(x + " ");
    return function(x - 1);
}
Console.Write(function(n));