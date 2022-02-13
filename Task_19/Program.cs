// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Введите координаты точки: ");
Console.Write("X = ");
int x = int.Parse(Console.ReadLine());
Console.Write("Y = ");
int y = int.Parse(Console.ReadLine());
if (x > 0 & y > 0) Console.WriteLine("Точка находится в I четверти");
if (x < 0 & y > 0) Console.WriteLine("Точка находится во II четверти");
if (x < 0 & y < 0) Console.WriteLine("Точка находится в III четверти");
if (x > 0 & y < 0) Console.WriteLine("Точка находится в IV четверти");