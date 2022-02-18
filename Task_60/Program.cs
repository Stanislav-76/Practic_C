// Составить частотный словарь элементов двумерного массива
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
void sortArray(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        int min = arr[j, 0];
        for (int n = j + 1; n < arr.GetLength(0); n++)
        {
            if (arr[n, 0] < min && arr[n, 1] > 0)
            {
                arr[j, 0] = arr[n, 0];
                arr[n, 0] = min;
                min = arr[j, 1];
                arr[j, 1] = arr[n, 1];
                arr[n, 1] = min;
                min = arr[j, 0];
            }
        }
    }
}
// пробуем в одной функции выдать массив c данными
void frequencyOutputArray(int[,] arr, int[,] arrOutput)
{
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int count = 0;
            for (int m = i; m < arr.GetLength(0); m++)
            {
                for (int n = 0; n < arr.GetLength(1); n++)
                {
                    if (arr[m, n] == arr[i, j]) count++;                    
                }
            }
            for (int d = 0; d <= index; d++)
            {
                if (d == index)
                {
                    arrOutput[index, 0] = arr[i, j];
                    arrOutput[index, 1] = count;
                    index++;
                    break;
                }
                if (arr[i, j] == arrOutput[d, 0] && arrOutput[d, 1] > 0) break;                
            }

        }
    }
}

int findNumArray(int[,] arr, int num)
{
    int count = 0;
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            if (arr[m, n] == num) count++;
        }
    }
    return count;
}
bool coincide(int[,] arr, int num, int k)
{
    for (int m = 0; m <= k; m++)
    {
        if (arr[m, 0] == num && arr[m, 1] > 0) return true;
    }
    return false;
}
int[,] array = new int[3, 3];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int[,] frequencyAnalysArray = new int[array.GetLength(0) * array.GetLength(1), 2];
int[,] frequencyAnalysArrays = new int[array.GetLength(0) * array.GetLength(1), 2]; // 2 массив для пробы функции
int k = 0;  //типа индекс
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {

        if (!(coincide(frequencyAnalysArray, array[i, j], k)))
        {
            frequencyAnalysArray[k, 0] = array[i, j];
            frequencyAnalysArray[k, 1] = findNumArray(array, array[i, j]);
            k++;
        }
    }
}
sortArray(frequencyAnalysArray);
for (int i = 0; i < frequencyAnalysArray.GetLength(0) && frequencyAnalysArray[i, 1] > 0; i++)
    Console.WriteLine($"{frequencyAnalysArray[i, 0]} встречается {frequencyAnalysArray[i, 1]} раз");
Console.WriteLine();
// Получаем массив сразу через функцию
frequencyOutputArray(array, frequencyAnalysArrays);
sortArray(frequencyAnalysArrays);
for (int i = 0; i < frequencyAnalysArrays.GetLength(0) && frequencyAnalysArrays[i, 1] > 0; i++)
    Console.WriteLine($"{frequencyAnalysArrays[i, 0]} встречается {frequencyAnalysArrays[i, 1]} раз");