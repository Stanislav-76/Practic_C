// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool X = true;
bool Y = true;
bool var1 = !(X | Y) == (!X & !Y);
bool var2 = !(X | !Y) == !X & !(!Y);
bool var3 = !(!X | Y) == (!(!X) & !Y);
bool var4 = !(!X | !Y) == !(!X) & !(!Y);
if (var1 && var2 && var3 && var4) Console.WriteLine("Выражение TRUE");
else Console.WriteLine("Выражение FALSE");