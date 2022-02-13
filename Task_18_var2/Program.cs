// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool vyr(bool x, bool y)
{
    bool d = !(x | y) == (!x & !y);
    return d;
}
bool X = true;
bool Y = true;
bool var1 = vyr(X, Y);
bool var2 = vyr(!X, Y);
bool var3 = vyr(X, !Y);
bool var4 = vyr(!X, !Y);
if (var1 && var2 && var3 && var4) Console.WriteLine("Выражение TRUE");
else Console.WriteLine("Выражение FALSE");