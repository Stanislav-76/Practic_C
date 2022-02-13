// Найти сумму чисел одномерного массива стоящих на нечетной позиции
void FillArray (int[] arrays)
{
    for (int i = 0; i < arrays.Length; i++)
    {
    arrays[i] = new Random().Next(0, 100);
    Console.Write(arrays[i] + " ");
    }
    Console.WriteLine();
}
int[] array = new int[10];
FillArray(array);
int sum = 0;
for (int i = 1; i < array.Length; i+=2) sum = sum + array[i];
Console.WriteLine($"Сумма чисел одномерного массива стоящих на нечетной позиции: {sum}");