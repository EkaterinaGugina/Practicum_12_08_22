// Программа, которая на вход принимает два числа и выдаёт, является ли второе кратным первому, а если нет выдает остаток от деления первого на второе.
Console.WriteLine("Введите два числа, и мы выведем кратно ли второе первому");
Console.Write("number1 =");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("number2 =");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 % number2 == 0)
    {
     Console.Write($"Число {number1} кратно числу {number2}");
    }
else
    {
    Console.Write($"Числа не кратны, и остаток от деления {number1} на {number2} равен {number1 % number2}"); 
    }   
