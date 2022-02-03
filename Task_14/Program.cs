// Найти третью цифру числа или сообщить, что её нет
int stepen(int y)
{
    int count = 0;
    int step = 1;
    while (count < y)
    {
        step = step * 10;
        count++; 
    }
    return step;
}
Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());
string num = Console.ReadLine();
int number = int.Parse(num);
int x = num.Length;
if (x > 2)
{
    Console.WriteLine("Третья цифра числа " + number % stepen(x-2) / stepen(x-3));
}
else
{
Console.WriteLine("Третья цифра отсутствует");
}