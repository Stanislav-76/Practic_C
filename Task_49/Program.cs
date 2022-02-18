// Показать двумерный массив размером m×n заполненный вещественными числами
double[,] array = new double[4, 3];
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double d = new Random().Next(0, 1000);
        array[i,j] = d/100;
        Console.Write(array[i,j] + "  ");
    }
Console.WriteLine();
}