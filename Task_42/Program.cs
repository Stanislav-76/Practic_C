// Определить сколько чисел больше 0 введено с клавиатуры
// Вариант 1
Console.WriteLine("Сколько чисел хотите ввести?");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите числа:");
int[] num = new int[number];
int count = 0;
for (int i = 0; i < number; i++)
{
    num[i] = int.Parse(Console.ReadLine());
    if (num[i] > 0) count++;
}
Console.WriteLine("Введено чисел больше 0: " + count);
// Вариант 2
Console.WriteLine("Введите числа через пробел:");
string number1 = Console.ReadLine();
string[] num1 = number1.Split(' ');
int count1 = 0;
for (int i = 0; i < num1.Length; i++)
{
    int x = int.Parse(num1[i]);
    if (x > 0) count1++;
}
Console.WriteLine("Введено чисел больше 0: " + count1);
