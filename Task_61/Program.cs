// Найти произведение двух матриц
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
int[,] arrayA = new int[3, 3];
int[,] arrayB = new int[3, 3];
FillArray(arrayA);
FillArray(arrayB);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
int[,] arrayAB = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
for (int i = 0; i < arrayA.GetLength(0); i++)
{
    if (arrayA.GetLength(1) != arrayB.GetLength(0)) break;
    for (int j = 0; j < arrayB.GetLength(1); j++)
    {
        for (int m = 0; m < arrayA.GetLength(1); m++)
        {
            arrayAB[i, j] = arrayAB[i, j] + arrayA[i, m] * arrayB[m, j];
        }
    }
}
if (arrayA.GetLength(1) == arrayB.GetLength(0)) PrintArray(arrayAB);
else Console.WriteLine("Массивы невозможно умножить");