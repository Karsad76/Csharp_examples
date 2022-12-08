int[] array = new int[20]; // Определяем массив

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

void PrintArray(int[] col)      // Метод печати массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]); Console.Write(" ");
        position++;
    }
}

void SortSelectionArray(int[] arr)      // Метод сортировки массива выбором Макс
{
    for (int i = 0; i < (arr.Length - 1); i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[maxPosition]) maxPosition = j;
        }

        int temp = arr[i];
        arr[i] = arr[maxPosition];
        arr[maxPosition] = temp;
    }
}

FillArray(array); // Заполняем массив случайными числами
PrintArray(array);
Console.WriteLine();
SortSelectionArray(array);
PrintArray(array);
