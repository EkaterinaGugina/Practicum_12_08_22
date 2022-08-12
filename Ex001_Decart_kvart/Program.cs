// Программа, которая на вход принимает два числа и проверяет, является ли одно квадратом другого.
Console.WriteLine("Введите два целых числа, и мы выведем, является ли одно из них квадратом другого");
Console.Write("a =");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("b =");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB)
    {
     Console.WriteLine($"{numberA} квадрат {numberB}");
    }
else if (numberB == numberA * numberA)
    {
     Console.WriteLine($"{numberB} квадрат {numberA}");
    }
else
    {
     Console.WriteLine("Среди этих чисел нет квадрата другого");
    }
