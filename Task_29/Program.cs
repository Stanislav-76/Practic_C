// Написать программу вычисления произведения чисел от 1 до N
int n = new Random().Next(1, 10);
int result = 1;
for (int index = 2; index <= n; index++) result = result * index;
Console.WriteLine($"{n}! = {result}");