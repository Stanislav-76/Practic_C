// Найти расстояние между точками в пространстве 2D/3D
int inchXA = 1, inchYA = 6, inchZA = 6;
int inchXB = 4, inchYB = 3, inchZB = 5;
int XAB = inchXA - inchXB;
int YAB = inchYA - inchYB;
int ZAB = inchZA - inchZB;
double d = Math.Sqrt(XAB*XAB + YAB*YAB + ZAB*ZAB);
Console.WriteLine("Расстояние между точками = " + d);