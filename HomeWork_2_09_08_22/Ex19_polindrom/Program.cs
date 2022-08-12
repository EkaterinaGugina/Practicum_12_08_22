// Это программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трёхзначное число, и мы выведем его вторую цифру, number = ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    int num = (number / 10) % 10;
    Console.WriteLine($"Ввели число {number}, а его вторая цифра равна {num}");
}
else 
{
    Console.WriteLine($"Число {number} не является трехзначным!");
}