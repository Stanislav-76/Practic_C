// По заданному номеру дня недели вывести его название
string[] weekDays = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
Console.WriteLine("Введите день недели от 1 до 7: ");
int n = int.Parse(Console.ReadLine());
if (n > 0 & n < 8)
{
    Console.WriteLine(weekDays[n-1]);    
}
else
{
    Console.WriteLine("Неверно указан день недели!");
}