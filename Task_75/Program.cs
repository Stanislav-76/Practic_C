// Есть два массива info и data.
// Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей.
// Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.
// Составить массив десятичных представлений чисел массива data с учётом информации из массива info.
// Пример:
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1
int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int n = 0;
for (int i = 0; i < info.Length; i++)
{
    if (n + info[i] > data.Length)
    {
        Console.WriteLine("Ошибка! Недостаточно данных в массиве data.");
        break;
    }
    if (n + info[i] < data.Length && i == info.Length - 1)
    {
        Console.WriteLine("Ошибка! Избыток данных в массиве data.");
        break;
    }
    double number = 0;
    for (int k = n; k < n + info[i]; k++)
    {
        number = number + Math.Pow(2, (n + info[i] - k - 1)) * data[k];
    }
    n = n + info[i];
    if (i < info.Length - 1) Console.Write(number + ", ");
    else Console.Write(number);
}