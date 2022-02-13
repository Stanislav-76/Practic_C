// Показать числа Фибоначчи
int num1 = 0;
int num2 = 1;
Console.Write(num1 + "  " + num2 + "  ");
for (int index = 0; index < 44; index++)
{
    int sum = num1 + num2;
    Console.Write(sum +"  ");
    num1 = num2;
    num2 = sum;
}