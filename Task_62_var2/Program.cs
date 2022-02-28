// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 100);
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
(int, int) MinArray(int[,] array)
{
    int min = array[0,0];
    int xMin = 0;
    int yMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                xMin = i;
                yMin = j;
            }
        }
    }
    return (xMin, yMin);
}

int[,] array = new int[5, 5];
int[,] arrayNew = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int xMin = 0, yMin = 0;
(xMin, yMin) = MinArray(array);
Console.WriteLine("Наименьший элемент " + array[xMin, yMin]);
int m = 0;
int n = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == xMin || j == yMin) continue;
        if (i < xMin) m = i; else m = i - 1;
        if (j < yMin) n = j; else n = j - 1;
        arrayNew[m, n] = array[i, j];
    }
}
PrintArray(arrayNew);