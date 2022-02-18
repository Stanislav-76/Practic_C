// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).
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
int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
if (array.GetLength(0) == array.GetLength(1))
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int num = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = num;
        }
    }
    PrintArray(array);
}
else Console.WriteLine("Заменить строки на столбцы невозможно, матрица не квадратная");