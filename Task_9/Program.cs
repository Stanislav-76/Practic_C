// Показать последнюю цифру трёхзначного числа
int function(int number)
{
    int n = number%10;
    return n;
}
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Последняя цифра " + function(number));