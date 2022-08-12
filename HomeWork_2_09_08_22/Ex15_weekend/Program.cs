//Программа, принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру, обозначающую день недели, и мы выведем является ли этот день выходным.");
Console.Write("number = ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number == 6) || (number == 7))
    {
     Console.WriteLine("Этот день является выходным.");
    }
else 
    if ((number >= 1) && (number <= 5))
        {
        Console.WriteLine("Этот день не является выходным.");
        }
    else 
        {
        Console.WriteLine("Неверная цифра дня недели!"); 
        }