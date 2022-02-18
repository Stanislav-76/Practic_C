// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "   ");
        }
        Console.WriteLine();
    }
}
int[,] array = new int[4, 5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
for (int i = 0; i < array.GetLength(1); i++)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(0); j++) sum = sum + array[j, i];        
    Console.WriteLine($"Среднее арифметическое столбца {i} = {sum / array.GetLength(0)}");
}