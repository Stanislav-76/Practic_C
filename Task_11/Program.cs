// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int function(int number)
{
    int n = number%10;
    if (n < number/10) n = number/10;
    return n;
}
Console.WriteLine("Введите число от 10 до 99: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Наибольшая цифра числа " + function(number));