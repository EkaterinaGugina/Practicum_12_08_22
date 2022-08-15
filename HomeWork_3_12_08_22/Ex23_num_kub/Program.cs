// Программа, которая на вход принимает число (N), а на выходе выдает кубы чисел от 1 до N.
Console.Write("Введите целое число  ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;                                      // счетчик цкла

while (i <= number)
{
    Console.Write($"  {Math.Pow(i, 3)}");
    i++;
}