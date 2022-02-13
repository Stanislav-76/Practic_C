// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine());
if (n/10000 == n%10 & n/1000%10 == n%100/10)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");