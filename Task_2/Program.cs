// Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите число 1: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int n2 = int.Parse(Console.ReadLine());
if (n1 > n2)
{
    Console.WriteLine("Число 1 = " + n1 + " больше числа 2 = " + n2 );
}
else
{
    if (n1 < n2)
    {
        Console.WriteLine("Число 2 = " + n2 + " больше числа 1 = " + n1);
    }
    else
        Console.WriteLine("Числа равны");
}