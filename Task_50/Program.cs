// В двумерном массиве n×k заменить четные элементы на противоположные
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
int[,] array = new int[4, 3];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + "  ");
        if (array[i, j] % 2 == 0) array[i, j] = array[i, j] * -1;
    }
    Console.WriteLine();
}
PrintArray(array);