// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
void FillArray (int[] arrays)
{
    for (int i = 0; i < arrays.Length; i++)
    arrays[i] = new Random().Next(100, 1000);
}
int[] array = new int[8];
FillArray(array);
int countchet = 0;
int countnechet = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0) countchet++;
    if (array[i]%2 == 1) countnechet++;
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine($"Количество нечетных чисел: {countnechet}");
Console.WriteLine($"Количество четных чисел: {countchet}");