// Написать программу возведения числа А в целую стень B
int a = 3;
int b = 5;
int stepenAB(int x, int y)
{
    if (y == 0) return 1;
    return stepenAB(x, y - 1) * x;
}
Console.WriteLine($"Число {a} в степени {b} = {stepenAB(a, b)}");