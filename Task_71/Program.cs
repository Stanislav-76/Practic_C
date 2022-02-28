// Написать программу вычисления функции Аккермана
int m = 1, n = 2;
int akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return akkerman(m - 1, 1);
    return akkerman(m - 1, akkerman(m, n - 1));
}
Console.WriteLine(akkerman(m, n));