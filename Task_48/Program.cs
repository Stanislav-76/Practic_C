// Показать двумерный массив размером m×n заполненный целыми числами
int[,] array = new int[4, 3];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}