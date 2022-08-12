// Программа, которая на вход принимает случайное число и выдаёт, большую его цифру.
Console.Clear();
int num = new Random().Next(10, 100);
int a = num / 10;
int b = num % 10;
int max = a;
if (max < b)
    {
     max = b;
    }
Console.WriteLine($"Наибольшая цифра числа {num} равна {max}");
        