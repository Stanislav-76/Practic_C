// Написать программу преобразования десятичного числа в двоичное
Console.WriteLine("Введите десятичное число: ");
int numberDecimal = int.Parse(Console.ReadLine());
int numberBinary = 0;
int stepen = 1;
//int count = 0;
while (numberDecimal > 0)
{
    numberBinary = numberBinary + numberDecimal % 2 * stepen;
    numberDecimal = numberDecimal / 2;
    stepen = stepen * 10;
}
Console.WriteLine("Двоичное число: " + numberBinary);