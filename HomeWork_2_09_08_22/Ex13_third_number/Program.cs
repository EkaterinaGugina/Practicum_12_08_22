// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Console.WriteLine("Введите целое число, и мы выведем его третью цифру. Number = ");
//string? number_str = Convert.ToString(Console.ReadLine());
//int length = number_str.Length;
//if (length > 2)
//{
 // Console.WriteLine($"Третья цифра числа {number_str} равна {number_str[2]}.");
//}
//else 
//{
//  Console.WriteLine($"В числе {number_str} нет третьей цифры.");  
//}

// Второй способ (без использования типа "строка")

Console.WriteLine("Введите целое число, и мы выведем его третью цифру. Number = ");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = number;   // для преобразований над данным числом, его "обрезки" и замены последних цифр нулями
int deg = 1;         // для подсчета степени 10.

if (number > 99)
{
    while (num1 > 100)     //считаем "длину" числа
    {
        num1 /= 10;
        deg  *= 10;
    }
        num1 = (number - num1 * deg) / (deg / 10);  //делим на (deg / 10), т.к. первую цифру полученного в цикле числа, хотим оставить (количество цифр deg и num1 одинаковое)
        Console.WriteLine($"Третья цифра числа {number} равна {num1}.");
}
else 
{
    Console.WriteLine($"В числе {number} нет третьей цифры.");
}