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


//не работает
int n = 10;
int m = 0;
void PrintArrayGroup(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"Группа {i + 1}: ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > 0) Console.Write(arr[i, j] + "   ");
        }
        Console.WriteLine();
    }
}
int countGroup(int x)
{
    if (x == 0) return m;
    x = x / 2;
    m++;
    return countGroup(x);
}
m = countGroup(n);
Console.WriteLine(m);

int[,] numberGroup = new int[m, n];
//numberGroup[0, 0] = 1;
int zz = 0;
for (int i = 1; i <= n; i++)
{
    bool exit = true;
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < i; k++)
        {
            if (numberGroup[j, k] > 0 && i % numberGroup[j, k] > 0)
            {
                exit = true;
                Console.WriteLine("Проверка1 " + "j " + j + " k " + k + " i " + i + " " + exit);
                continue;
                //numberGroup[k, j] = i;
                //break;
            }
            if (exit == true) numberGroup[j, k] = i;
            Console.WriteLine("Проверка2 " + "j " + j + " k " + k + " i " + i + " " + exit);
            exit = false;
            break;
        }
        if (exit == false) break;
    }
}
PrintArrayGroup(numberGroup);
