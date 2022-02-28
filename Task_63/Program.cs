// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно 
// на экран выводя индексы соответствующего элемента
void FillArray(int[,,] arr)
{
    int[] num = new int[arr.Length];
    int n = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
            NextRandom:
                arr[i, j, k] = new Random().Next(10, 100);
                for (int m = 0; m < n; m++)
                {
                    if (arr[i, j, k] == num[m]) goto NextRandom;
                }
                num[(n)] = arr[i, j, k];
                n++;
            }
        }
    }
}
void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.WriteLine($"{i}, {j}, {k} = {arr[i, j, k]}");
            }
        }
    }
}
int[,,] array = new int[4, 3, 3];
if (array.Length <= 90)
{
    FillArray(array);
    PrintArray(array);
}
else Console.WriteLine("Невозможно заполнить массив не повторяющимися двузначными числами. Размер массива не должен превышать 90.");