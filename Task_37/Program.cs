// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void FillArray (int[] arrays)
{
    for (int i = 0; i < arrays.Length; i++)
    arrays[i] = new Random().Next(0, 1000);
}
int[] array = new int[123];
FillArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <=99 ) count++;
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine($"Количество элементов из отрезка [10,99]: {count}");