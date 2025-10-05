//Лабараторная работа #1
//Арифметические выражения
//Вариант 25. Высокий
Console.Write("введите a");
double a =double.Parse(Console.ReadLine());
Console.Write("введите y");
double y = double.Parse(Console.ReadLine());
Console.Write("введите x");
double x = double.Parse(Console.ReadLine());

double b = (Math.Pow(1 / Math.Tan(Math.Pow(a, 3) * Math.PI / 180), 3));
double c = (Math.Pow(Math.Atan(a), 2) * Math.PI / 180);
Console.WriteLine($"J={(b+c) / (Math.Sqrt(Math.Pow(y, Math.Tan(x)* Math.PI / 180))):f2}");
