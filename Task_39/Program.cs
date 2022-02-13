// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
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
int result = 0;
int len = array.Length;
for (int i = 0; i < len/2; i++)
{
    result = array[i] * array[len - 1 - i];
    Console.WriteLine(array[i] + " " + array[len - 1 - i] + " " + result);
}