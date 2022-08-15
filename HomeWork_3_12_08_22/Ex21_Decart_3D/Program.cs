// Программа, которая принимает на вход координаты двух точек и выдаёт расстояние между ними в пространстве
Console.Write("Введите координаты двух точек ");
Console.Write("x_a =");
int x_a = Convert.ToInt32(Console.ReadLine());
Console.Write("y_a =");
int y_a = Convert.ToInt32(Console.ReadLine());
Console.Write("z_a =");
int z_a = Convert.ToInt32(Console.ReadLine());

Console.Write("x_b =");
int x_b = Convert.ToInt32(Console.ReadLine());
Console.Write("y_b =");
int y_b = Convert.ToInt32(Console.ReadLine());
Console.Write("z_b =");
int z_b = Convert.ToInt32(Console.ReadLine());

double r = Math.Sqrt(Math.Pow((x_a - x_b), 2) + Math.Pow((y_a - y_b), 2) + Math.Pow((z_a - z_b), 2));

Console.Write($"Расстояние между этими точками равно  {Math.Round(r, 2)}");
