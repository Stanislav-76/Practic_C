// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
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
void sortStringArray(int x, int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int min = arr[x,j];
        for (int n = j + 1; n < arr.GetLength(1); n++)
        {
            if (arr[x,n] < min)
            {
                arr[x,j] = arr[x,n];
                arr[x,n] = min;
                min = arr[x,j];
            }
        }
    }
}


int[,] array = new int[5, 6];
FillArray(array);
PrintArray(array);
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    sortStringArray(i, array);
}
PrintArray(array);