// Выяснить, кратно ли число заданному, если нет, вывести остаток.
int number1 = 4;
int number2 = 72;
if(number2 % number1 == 0)
{
    Console.WriteLine($"Число {number2} кратно заданному {number1}");
}
else
    Console.WriteLine("Число не кратно заданному, остаток " + number2 % number1);