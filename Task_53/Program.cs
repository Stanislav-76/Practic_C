// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
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
int num = int.Parse(Console.ReadLine());
int count = 0;
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        if(num == array[i,j])
        {Console.WriteLine($"Позиция числа ({i},{j})");
        count++;
        }        
    }
}
if (count == 0) Console.WriteLine("Число отсутствует.");