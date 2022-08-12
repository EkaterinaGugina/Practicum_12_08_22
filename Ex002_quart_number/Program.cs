// Программа, которая принимает на вход число  - номер координатной четверти и выдаёт диапазон значений для координат точек этой четверти
Console.Write("Введите номер координатной четверти, number = ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <0 || number > 4)
{
    Console.WriteLine("Это не номер четверти!");
}
if (number == 1)
     {
        Console.WriteLine("x > 0, y > 0");
     } 
if (number == 4)
     {
        Console.WriteLine("x > 0, y < 0");
     }  
if (number == 2)
     {
        Console.WriteLine("x < 0, y > 0");
     }
if (number == 3)
     {
        Console.WriteLine("x < 0,  y < 0");
     }