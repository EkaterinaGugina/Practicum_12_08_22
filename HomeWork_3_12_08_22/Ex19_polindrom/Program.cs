// Это программа, которая принимает на вход пятизначное число и проверяет, полиндром ли это.
Console.Write("Введите пятизначное число, number = ");
int number = Convert.ToInt32(Console.ReadLine());
int n1 = number / 10000;        // первая цифра числа
int n2 = (number / 1000) % 10;  // вторая цифра числа

int n4 = (number / 10) % 10;   // четвертая цифра числа
int n5 = number % 10;      // последняя (пятая) цифра числа

if ((n1 == n5) && (n2 == n4))
     Console.WriteLine($"Число {number} - полиндром");  
else Console.WriteLine($"Число {number} - не является полиндромом");