// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
string[] weekDays = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
Console.WriteLine("Введите день недели от 1 до 7: ");
int n = int.Parse(Console.ReadLine());
if (n > 5 & n < 8)
{
    Console.WriteLine($"Это {weekDays[n-1]} - выходной день!");
}
else if (n > 0 & n < 6)
{
    Console.WriteLine($"Это {weekDays[n-1]} - не выходной день!");
}
else
{
    Console.WriteLine("Неверно указан день недели!");
}