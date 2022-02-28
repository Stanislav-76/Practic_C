// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
Console.Write("Введите количество строк : ");
int n = int.Parse(Console.ReadLine());
int[,] triangle = new int[n, n];
triangle[0, 0] = 1;
for (int i = 1; i < n; i++)
{
    for (int j = 0; j <= i; j++)
    {
        if (j == 0 || j == i) triangle[i, j] = 1;
        else triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
    }
}
for (int i = 0; i < n; i++)
{
    //Console.SetCursorPosition(n + n/2 - i,i + 10);
    for (int k = 0; k <= n - i; k++)
    {
        Console.Write("{0,-3}", "");
    }
    for (int j = 0; j <= i ; j++)
    {
        Console.Write("{0,-3}   ", triangle[i, j] + "");
    }
    Console.WriteLine();
}
