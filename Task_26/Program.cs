// Возведите число А в натуральную степень B используя цикл
int A  = 3;
int B = 6;
int result = 1;
for (int index = 0; index < B; index++) result = result * A;
Console.WriteLine($"{A}^{B} = {result}");