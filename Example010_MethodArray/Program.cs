// Найти введенное число в заданном массиве. Если не найдено - сообщить.
int[] array = { 121, 121, 147, 754, 65132, 168, 754, 47, 5, 4, 754, 84, 514 };

int n = array.Length;

Console.Write("Введите искомое число: ");

string? findLine = Console.ReadLine();
if (findLine != null)
{
    int find = int.Parse(findLine);

    int index = 0;

    while (index < n)
    {
        if (find == array[index])
        {
            Console.Write ("Число найдено с индексом: "); Console.WriteLine(index);
            break;
        }
        index++;
    }
    if (index >= n)
    {
        Console.WriteLine("Число не найдено");
    }
}