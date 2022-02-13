// Определить, присутствует ли в заданном массиве, некоторое число
int[] array = {6, 7, 56, -5, -12, 34};
int len = array.Length;
int poisk = int.Parse(Console.ReadLine());
for (int index = 0; index < len; index++)
{
    if (array[index] == poisk)
    {
        Console.WriteLine("Искомое число присутствует в массиве.");
        break;
    }
    else if (index == len - 1) Console.WriteLine("Искомое число отсутствует в массиве.");
}