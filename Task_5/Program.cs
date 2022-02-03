// Написать программу вычисления значения функции y = f(a)
double function(double number)
{
    double index = 1;
    double sum = 0;
    while(index <= number)
    {
        sum = sum + Math.Pow(number, index) + 1;
        index++;        
    }
    return sum;
}
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Значение функции равно " + function(number));