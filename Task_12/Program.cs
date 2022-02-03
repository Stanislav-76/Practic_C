// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("После удаления второй цифры будет число " + (number/100*10 + number%10));