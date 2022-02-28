// Спирально заполнить двумерный массив:
//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,-3} ", arr[i, j]);
        }
        Console.WriteLine();
    }
}
int[,] array = new int[5, 7];
int num = 1;
for (int i = 0; i < (array.GetLength(0) + 1) / 2; i++)
{

    for (int x = i; x < array.GetLength(1) - i; x++) //вправо
    {
        array[i, x] = num;
        //Console.WriteLine(array[i, x] + "вправо");
        num++;
    }
    for (int y = i + 1; y < array.GetLength(0) - i; y++) //вниз
    {
        array[y, array.GetLength(1) - 1 - i] = num;
        //Console.WriteLine(array[y, array.GetLength(1) - 1 - i] + "вниз");
        num++;
    }
    for (int m = array.GetLength(1) - 1 - i; m > i; m--) //влево
    {
        if (i == array.GetLength(0) / 2) break;
        array[array.GetLength(0) - 1 - i, m - 1] = num;
        //Console.WriteLine(array[array.GetLength(0) - 1 - i, m - 1] + "влево");
        num++;
    }
    for (int n = array.GetLength(0) - 2 - i; n > i; n--) //вверх
    {
        array[n, i] = num;
        //Console.WriteLine(array[n, i] + "вверх");
        num++;
    }
}
PrintArray(array);