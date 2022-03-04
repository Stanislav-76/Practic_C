// Есть число N. Скольно групп M, можно получить при разбиении всех чисел на группы, 
// так чтобы в одной группе все числа были взаимно просты.
// Например для N = 50, M получается 6
// Одно из решений :
// Группа 1: 1 
// Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47 
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
// Группа 5: 7 16 24 36 40 
// Группа 6: 5 32 48
// Задача: найти M при заданном N и получить одно из разбиений на группы N ≤ 10²⁰


ulong n = 50;
ulong m = 0;
void PrintArrayGroup(ulong[,] arr)
{
    for (ulong i = 0; i < Convert.ToUInt64(arr.GetLength(0)); i++)
    {
        Console.Write($"Группа {i + 1}: ");
        for (ulong j = 0; j < Convert.ToUInt64(arr.GetLength(1)); j++)
        {
            if (arr[i, j] > 0) Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
ulong countGroup(ulong x)
{
    if (x == 0) return m;
    m++;
    return countGroup(x / 2);
}
m = countGroup(n);
Console.WriteLine($"Для числа {n} групп {m}");
ulong[,] numberGroup = new ulong[m, n];
for (ulong i = 1; i <= n; i++)
{
    bool exit = false;
    for (ulong j = 0; j < m; j++)
    {
        for (ulong k = 0; k < i; k++)
        {
            if (numberGroup[j, k] > 0 && i % numberGroup[j, k] == 0)
            {
                //Console.WriteLine("Проверка1 " + "j " + j + " k " + k + " i " + i + " " + exit);
                break;
            }
            if (numberGroup[j, k] == 0)
            {
                numberGroup[j, k] = i;
                exit = true;
                //Console.WriteLine("Проверка2 " + "j " + j + " k " + k + " i " + i + " " + exit);
                break;
            }
        }
        if (exit == true) break;
    }
}
PrintArrayGroup(numberGroup);
