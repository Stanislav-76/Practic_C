// В матрице чисел найти сумму элементов главной диагонали
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
int sum = 0;
int m = array.GetLength(0);
if (m > array.GetLength(1)) m = array.GetLength(1);
for (int i = 0; i < m; i++)
{
    sum = sum + array[i, i];
}
Console.WriteLine("Сумма элементов главной диагонали = " + sum);