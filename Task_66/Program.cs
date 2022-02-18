// Показать натуральные числа от 1 до N, N задано
int n = 15;
string function(int x)
{
    if (x == 1) return "1";
    return function(x - 1) + " " + x;
}
Console.WriteLine(function(n));

int i = 1;
int function1(int x)
{
    if (x == 0) return x;
    Console.Write(i + " ");
    i++;
    return function1(x - 1);
}
function1(n);