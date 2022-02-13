// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] array = new int[12];
int index = 0;
int sumplus = 0;
int summinus = 0;
while (index < 12)
{
    array[index] = new Random().Next(0, 10);
    Console.Write(" " + array[index]);
    if (array[index] > 0) sumplus = sumplus + array[index];
    if (array[index] < 0) summinus = summinus + array[index]; 
    index++;
}
Console.WriteLine();
Console.WriteLine("Сумма положительных элементов массива = " + sumplus);
Console.WriteLine("Сумма отрицательных элементов массива = " + summinus);