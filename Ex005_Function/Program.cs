// Создадим заготовки функций (методов)
int[] array = {1, 2, 3, 4, 5};
int[] array = new int[];
int n = array.Length;

//Метод Ввода массива с консоли
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    } 
}

//Метод Вывод массива на экран
void PrintArray(int[] col)
{
    Console.Clear;
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }  
}

//Метод Нахождение индекса требуемого элемента
void IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
{
    Console.WriteLine(col[position]);
    position++;
}  
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
Console.WriteLine("Заполним массив. Введите элементы массива через Enter");
FillArray(array);

