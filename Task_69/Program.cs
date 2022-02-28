// Найти сумму элементов от M до N, N и M заданы
int m = 4;
int n = 8;
int sumNumber(int x, int y)
{
    if (x == y) return y;
    return sumNumber(x + 1, y) + x;
}
Console.WriteLine("Сумма элементов = " + sumNumber(m, n));