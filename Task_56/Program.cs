// Написать программу, которая обменивает элементы первой строки и последней строки
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
int[,] array = new int[6, 5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
for (int i = 0; i < array.GetLength(1); i++)
{
    int num = array[0, i];
    array[0, i] = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) - 1, i] = num;
}
PrintArray(array);