// Программа, которая на вход принимает число (N), а на выходе пишет, кратно ли оно 7 и одновременно 23.
Console.WriteLine("Введите целое число, и мы выведем кратно ли оно 7 и одновременно 23.");
Console.Write("number =");
int number = Convert.ToInt32(Console.ReadLine());
if ((number % 7 == 0) && (number % 23 == 0))
{
    Console.WriteLine($"Число {number} кратно 7 и 23 одновременно.");
}
else 
{
    Console.WriteLine($"Число {number} им одновременно не кратно");
}
