// Задать двумерный массив следующим правилом: Aₘₙ = m+n
void PrintArray (int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + "   ");        
        }
    Console.WriteLine();
    }
}
int[,] array = new int[4, 3];
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = i + j;        
    }
}
PrintArray(array);