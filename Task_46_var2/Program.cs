// Написать программу масштабирования фигуры
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой) например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся. при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
string figura = "(0,0) (2,0) (2,2) (0,2)";
double k = 2.5;
Console.WriteLine(figura + "  k = " + k);
char[] separators = new char[] { ' ', '(', ')', ',' };
string[] digit = figura.Split(separators, StringSplitOptions.RemoveEmptyEntries);
string newfigura = "";
for (int i = 0; i < digit.Length/2; i++)
{
    //Console.Write(digit[i] + " ");
    double x = int.Parse(digit[i*2])*k;
    double y = int.Parse(digit[i*2+1])*k;
    newfigura = newfigura + $"({x.ToString()},{y.ToString()}) ";
}
Console.WriteLine(newfigura);