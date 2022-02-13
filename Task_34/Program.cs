// Написать программу замену элементов массива на противоположные
int[] array = {6, 7, 56, -5, -12, 34};
int len = array.Length;
int[] newArray = new int[len]; 
for (int index = 0; index < len; index++)
{
    newArray[index] = array[index] * -1;
    Console.Write(newArray[index] + " ");
}