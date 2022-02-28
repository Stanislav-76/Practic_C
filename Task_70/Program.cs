// Найти сумму цифр числа
int num = 17213;
int sumDigit(int x)
{
    if (x < 10) return x;
    return sumDigit(x / 10) + x % 10;
}
Console.Write("Сумма цифр = " + sumDigit(num));