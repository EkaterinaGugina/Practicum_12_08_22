// Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.Write("Введите трёхзначное число, и мы выведем его без второй цифры, number = ");
int number = Convert.ToInt32(Console.ReadLine());
int num = (number / 100) * 10 + number % 10;
Console.WriteLine($"Было число {number}, а стало {num}");
