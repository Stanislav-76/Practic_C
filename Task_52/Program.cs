// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void FillArray (int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0, 10);                    
        }
    }
}
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
int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
Console.WriteLine();
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        if(i%2 == 0 && j%2 == 0)
        array[i,j] = array[i,j] * array[i,j];        
    }
}
PrintArray(array);