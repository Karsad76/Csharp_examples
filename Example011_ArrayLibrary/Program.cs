// Найти введенное число в сгенерированном массиве и вывести количество найденных и первую найденную позицию

void FillArray(int[] collection) // Метод заполнения массива псевдослучайными числами
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] col) //Метод печати массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]); Console.Write(", ");
        position++;
    }
}

int FindIndexOfFirstPosition(int[] collection, int find) // Метод поиска первой позиции вхождения
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
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

int FindQtyInArray(int[] collection, int find) // Метод поиска количества вхождений в массиве
{
    int endLine = collection.Length;
    int index = 0;
    int qtyCount = 0;
    while (index < endLine)
    {
        if (collection[index] == find)
        {
            qtyCount = qtyCount + 1;
        }
        index++;
    }
    return qtyCount;
}

int[] array = new int[1000]; // Определяем массив
FillArray(array); // Заполняем массив случайными числами

Console.Write("Введите искомое число: "); // Запрашиваем число из консоли
string? findNumberLine = Console.ReadLine();

if (findNumberLine != null) // Проверяем на пустую строку
{
    int findNumber = int.Parse(findNumberLine); // Парсим в число
    PrintArray(array); // Готовим вывод
    Console.WriteLine();
    Console.WriteLine("==================================================");

    int pos = FindIndexOfFirstPosition(array, findNumber); // Определяем первую позицию вхождения в массиве
    int qty = FindQtyInArray(array, findNumber); // Определяем количество вхождений в массиве

    //Console.WriteLine(qty); ТЕСТОВЫЙ ВЫВОД
    //Console.WriteLine(pos);

    if (qty > 0 & pos != -1) //Проверяем на отсутсвие результата поиска
    {
        Console.Write("Найдено всего: "); Console.WriteLine(qty); // Вывод результата
        Console.Write("Первое на позиции: "); Console.WriteLine(pos);
    }
    else
    {
        Console.WriteLine("Число не найдено"); // Вывод если не найдено
    }
}
