// Написать программу копирования массива
void FillArray (int[] arrays)
{
    for (int i = 0; i < arrays.Length; i++)
    arrays[i] = new Random().Next(100, 1000);
}
void PrintArray (int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "   ");        
    }
    Console.WriteLine();
}
void CopyArray (int[] arr, int[] arrays)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arrays[i] = arr[i];        
    }
    Console.WriteLine();
}
int[] array = new int[8];
int[] newArray = new int[array.Length];
FillArray(array);
PrintArray(array);
CopyArray(array, newArray);
PrintArray(newArray);