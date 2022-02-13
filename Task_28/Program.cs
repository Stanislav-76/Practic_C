// Подсчитать сумму цифр в числе
int n = new Random().Next(1, 999999);
Console.WriteLine(n);
int sum = 0;
int len = $"{n}".Length;
for (int index = 0; index < len; index++)
{
    sum = sum + n%10;
    n = n/10;    
}
Console.WriteLine("Сумма цифр в числе = " + sum);