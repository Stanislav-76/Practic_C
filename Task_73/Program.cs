// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем
Console.WriteLine("Введите число 1:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int num2 = int.Parse(Console.ReadLine());
int n = 10;
string poslNumber(int x, int y, int n)
{
    if (n == 2) return "";
    return x + y + " " + poslNumber(y, x + y, n - 1);
}
Console.WriteLine(num1 + " " + num2 + " " + poslNumber(num1, num2, n));

//вариант 2
Console.Write(num1 + " " + num2 + " ");
int poslNumber2(int x, int y, int n)
{
    if (n == 3) return x + y;
    Console.Write(x + y + " ");
    return poslNumber2(y, x + y, n - 1);
}
Console.WriteLine(poslNumber2(num1, num2, n));