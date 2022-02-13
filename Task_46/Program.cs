// Написать программу масштабирования фигуры
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой) например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся. при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
string figura = "(0,0) (2,0) (2,2) (0,2)";
int k = 5;
Console.WriteLine(figura + "  k = " + k);
string[] digit = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
string newfigura = "";
int count = 0;
int temp = 0;
int indexOfChar = 0;
int len = figura.Length;
while (indexOfChar < len)
{
    while (count < 10)
    {    
    if ($"{figura[indexOfChar]}" == $"{digit[count]}")
    {
        temp = int.Parse($"{figura[indexOfChar]}");
        temp = temp * k;
        newfigura = newfigura + temp.ToString();
        break;
    }
    else if (count == 9) 
        newfigura = newfigura + figura[indexOfChar];
    count++;
    }
count = 0;
indexOfChar++;
}
Console.WriteLine(newfigura);