// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] array = new double[20];
int index = 0;
double max = 0;
double min = 100;
while (index < 20)
{
    double d = new Random().Next(0, 10000);
    array[index] = d / 100;
    Console.Write(" " + array[index]);
    if (array[index] > max) max = array[index];
    if (array[index] < min) min = array[index];
    index++;
}
Console.WriteLine();
Console.WriteLine(min + " " + max);
Console.WriteLine("Разница между максимальным и минимальным элементом = " + (max - min));