// Программа, для двух введенных с консоли чисел (координат точки) выводит в какой координатной четверти она лежит.
Console.WriteLine("Введите координаты точек");
Console.Write("x_a =");
int x_a = Convert.ToInt32(Console.ReadLine());
Console.Write("y_a =");
int y_a = Convert.ToInt32(Console.ReadLine());

if (x_a == 0 || y_a == 0)
{
    Console.WriteLine("Точка лежит на осях, не в четверти!");
}
if (x_a > 0 && y_a > 0)
     {
        Console.WriteLine("1 четверть");
     }
if (x_a > 0 && y_a < 0)
     {
        Console.WriteLine("4 четверть");
     }  
if (x_a < 0 && y_a > 0)
     {
        Console.WriteLine("2 четверть");
     }
if (x_a < 0 && y_a < 0)
     {
        Console.WriteLine("3 четверть");
     }